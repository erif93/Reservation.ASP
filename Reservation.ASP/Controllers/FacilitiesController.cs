using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reservation.ASP.Common.Interfaces.Hotelku;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Controllers
{
    public class FacilitiesController : Controller
    {
        private readonly IFacilityService _ifacilityservice;


        public FacilitiesController() { }
        public FacilitiesController(IFacilityService ifacilityservice)
        {
            this._ifacilityservice = ifacilityservice;
        }
        // GET: Facilities
        public ActionResult Index()
        {
            return View(_ifacilityservice.Get());
        }
        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FacilityParam _facilityparam )
        {
            if (ModelState.IsValid)
            {

                _ifacilityservice.Insert(_facilityparam);
                return RedirectToAction("Index");
            }
            return View(_facilityparam);
        }
        //GET
        public ActionResult Edit(int? id)
        {
            FacilityParam _facilityparam = new FacilityParam(_ifacilityservice.Get(id));

            return View(_facilityparam);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FacilityParam _facilityparam)
        {
            _ifacilityservice.Update(_facilityparam);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            _ifacilityservice.Delete(id);
            return RedirectToAction("Index");
        }

    }
}