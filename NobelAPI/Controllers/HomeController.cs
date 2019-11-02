using NobelAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NobelAPI.Controllers
{
    public class HomeController : Controller
    {
        NobelContext context = new NobelContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetNobels(string category, int year, string winner)
        {
            
            return Json(new AppService().AddNobel(category, year, winner));
        }

        [HttpGet]
        public JsonResult SendNobels()
        {
            var nobels = context.Nobels.ToList();

            return Json(nobels, JsonRequestBehavior.AllowGet);
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