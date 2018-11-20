using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reservation.ASP.Controllers
{
    public class TrainsController : Controller
    {
        // GET: Trains
        public ActionResult Index()
        {
            return View();
        }
    }
}