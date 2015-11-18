using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelLayer;

namespace ASPServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Location loc = new Location() { ZipCode = "9000", City = "Aalborg" };
            ViewBag.Location = loc.City;
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