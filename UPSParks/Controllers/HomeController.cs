using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPSParks.Context;

namespace UPSParks.Controllers
{
    public struct Floor
    {
        public int one;
        public int two;
        public int three;
        public int four;
        public int five;

    }


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

        public ActionResult Floors()
        {

            Floor floor1 = new Floor()
            {
                one = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "1Q1")).Count(),
                two = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "1Q2")).Count(),
                three = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) && */(x.regionID == "1Q3")).Count(),
                four = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "1Q4")).Count(),
                five = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "1Q5")).Count()
            };

            Floor floor2 = new Floor()
            {
                one = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "2Q1")).Count(),
                two = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "2Q2")).Count(),
                three = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) && */(x.regionID == "2Q3")).Count(),
                four = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "2Q4")).Count(),
                five = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "2Q5")).Count()
            };

            Floor floor3 = new Floor()
            {
                one = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "3Q1")).Count(),
                two = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "3Q2")).Count(),
                three = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) && */(x.regionID == "3Q3")).Count(),
                four = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "3Q4")).Count(),
                five = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "3Q5")).Count()
            };

            Floor floor4 = new Floor()
            {
                one = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "4Q1")).Count(),
                two = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "4Q2")).Count(),
                three = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) && */(x.regionID == "4Q3")).Count(),
                four = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "4Q4")).Count(),
                five = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "4Q5")).Count()
            };

            Floor floor5 = new Floor()
            {
                one = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "5Q1")).Count(),
                two = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "5Q2")).Count(),
                three = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) && */(x.regionID == "5Q3")).Count(),
                four = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "5Q4")).Count(),
                five = db.parkings.Where(x => (x.isTaken == true) && /*(x.floorID == 1) &&*/ (x.regionID == "5Q5")).Count()
            };



            ViewBag.Floor1 = floor1;
            ViewBag.Floor2 = floor2;
            ViewBag.Floor3 = floor3;
            ViewBag.Floor4 = floor4;
            ViewBag.Floor5 = floor5;



            return View();
        }
    }
}