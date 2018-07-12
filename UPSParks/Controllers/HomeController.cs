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
            ViewBag.Floor1 = db.parkings.Where(x => (x.isTaken == true) && (x.floorID == 1)).Count();
            ViewBag.Floor2 = db.parkings.Where(x => (x.isTaken == true) && (x.floorID == 2)).Count();
            ViewBag.Floor3 = db.parkings.Where(x => (x.isTaken == true) && (x.floorID == 3)).Count();
            ViewBag.Floor4 = db.parkings.Where(x => (x.isTaken == true) && (x.floorID == 4)).Count();
            ViewBag.Floor5 = db.parkings.Where(x => (x.isTaken == true) && (x.floorID == 5)).Count();

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