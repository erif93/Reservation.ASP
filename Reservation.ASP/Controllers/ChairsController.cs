using Reservation.ASP.BussinessLogic.Repository.Kereta;
using Reservation.ASP.Common.Interfaces.Kereta;
using Reservation.ASP.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reservation.ASP.Controllers
{
    public class ChairsController : Controller
    {
        IChairService _ChairService = new ChairService();
        // GET: Suppliers
        public ChairsController() { }
        public ChairsController(IChairService ChairService)
        {
            this._ChairService = ChairService;
        }
        public ActionResult Index()
        {
            IEnumerable<ChairParam> list_param = _ChairService.Get().Select(x => new ChairParam
            {
                Id = x.Id,
                Name = x.Name.ToString()
            });
            return View(list_param);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ChairParam _chairparam)
        {
            if (ModelState.IsValid)
            {
                _ChairService.Insert(_chairparam);
                return RedirectToAction("Index");
            }

            return View(_chairparam);
        }

        public ActionResult Edit(int? id)
        {
            var datachair = _ChairService.Get(id);
            ChairParam chair = new ChairParam(datachair);
            return View(chair);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ChairParam _chairparam)
        {
            if (ModelState.IsValid)
            {
                _ChairService.Update(_chairparam);
                return RedirectToAction("Index");
            }
            return View(_chairparam);
        }
        
        [HttpPost]
        public ActionResult Delete(int id)
        {
            _ChairService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}