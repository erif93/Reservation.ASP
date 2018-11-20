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
    public class TrainsController : Controller
    {
        ITrainService _TrainService = new TrainService();
        // GET: Suppliers
        public TrainsController() { }
        public TrainsController(ITrainService TrainService)
        {
            this._TrainService = TrainService;
        }
        public ActionResult Index()
        {
            IEnumerable<TrainParam> list_param = _TrainService.Get().Select(x => new TrainParam
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
        public ActionResult Create(TrainParam _trainparam)
        {
            if (ModelState.IsValid)
            {
                _TrainService.Insert(_trainparam);
                return RedirectToAction("Index");
            }

            return View(_trainparam);
        }

        public ActionResult Edit(int? id)
        {
            var datatrain = _TrainService.Get(id);
            TrainParam train = new TrainParam(datatrain);
            return View(train);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TrainParam _trainparam)
        {
            if (ModelState.IsValid)
            {
                _TrainService.Update(_trainparam);
                return RedirectToAction("Index");
            }
            return View(_trainparam);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _TrainService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}