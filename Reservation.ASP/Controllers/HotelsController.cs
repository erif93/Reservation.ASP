using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reservation.ASP.Common.Interfaces.Hotelku;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Controllers
{
    public class HotelsController : Controller
    {
        private readonly IHotelService _ihotelservice;
        public HotelsController() { }
        public HotelsController(IHotelService ihotelservice)
        {
            this._ihotelservice = ihotelservice;
        }
        // GET: Hotels
        public ActionResult Index()
        {
            return View(_ihotelservice.Get());
        }
        //GET
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HotelParam _hotelparam)
        {
            if (ModelState.IsValid)
            {

                _ihotelservice.Insert(_hotelparam);
                return RedirectToAction("Index");
            }
            return View(_hotelparam);
        }
        //GET
        public ActionResult Edit(int? id)
        {
            HotelParam _hotelparam = new HotelParam(_ihotelservice.Get(id));

            return View(_hotelparam);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HotelParam _hotelparam)
        {
            _ihotelservice.Update(_hotelparam);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            _ihotelservice.Delete(id);
            return RedirectToAction("Index");
        }
    }
}