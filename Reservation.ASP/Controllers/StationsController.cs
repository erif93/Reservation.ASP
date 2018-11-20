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
    public class StationsController : Controller
    {
        IStationService _StationService = new StationService();
        IDistrictService _DistrictService = new DistrictService();
        // GET: Suppliers
        public StationsController() { }
        public StationsController(IStationService StationService, IDistrictService DistrictService)
        {
            this._StationService = StationService;
            this._DistrictService = DistrictService;
        }
        public ActionResult Index()
        {
            IEnumerable<StationParam> list_param = _StationService.Get().Select(x => new StationParam
            {
                Id = x.Id,
                Name = x.Name.ToString(),
                Districts = x.Districts
            });
            return View(list_param);
        }

        public ActionResult Create()
        {
            var o = _DistrictService.Get();
            IEnumerable<SelectListItem> list = o.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name.ToString()
            });
            ViewBag.dropdowndistrict = list;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StationParam _stationparam)
        {
            if (ModelState.IsValid)
            {
                _StationService.Insert(_stationparam);
                return RedirectToAction("Index");
            }

            return View(_stationparam);
        }

        public ActionResult Edit(int? id)
        {
            var datastation = _StationService.Get(id);
            StationParam station = new StationParam(datastation);
            return View(station);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StationParam _stationparam)
        {
            if (ModelState.IsValid)
            {
                _StationService.Update(_stationparam);
                return RedirectToAction("Index");
            }
            return View(_stationparam);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _StationService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}