using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reservation.ASP.Common.Interfaces.Hotelku;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Controllers
{
    public class DetailHotelsController : Controller
    {
            private readonly IDetailHotelService _idetailhotelservice;
            public DetailHotelsController() { }
            public DetailHotelsController(IDetailHotelService idetailhotelservice)
            {
                this._idetailhotelservice = idetailhotelservice;
            }
            // GET: Hotels
            public ActionResult Index()
            {
                return View(_idetailhotelservice.Get());
            }
            //GET
            public ActionResult Create()
            {
                return View();
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create(DetailHotelParam _detailhotelparam)
            {
                if (ModelState.IsValid)
                {

                    _idetailhotelservice.Insert(_detailhotelparam);
                    return RedirectToAction("Index");
                }
                return View(_detailhotelparam);
            }
            //GET
            public ActionResult Edit(int? id)
            {
                DetailHotelParam _detailhotelparam = new DetailHotelParam(_idetailhotelservice.Get(id));

                return View(_detailhotelparam);
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit(DetailHotelParam _detailhotelparam)
            {
                _idetailhotelservice.Update(_detailhotelparam);
                return RedirectToAction("Index");

            }

            [HttpPost]
            public ActionResult Delete(int? id)
            {
                _idetailhotelservice.Delete(id);
                return RedirectToAction("Index");
            }
            // GET: DetailHotels
        }
    }
