using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPSParks.Context;

namespace UPSParks.Controllers
{
    public class HomeController : Controller
    {

        GTSFactoryEntities db = new GTSFactoryEntities();

        public ActionResult Index()
        {
            db.parkings
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}