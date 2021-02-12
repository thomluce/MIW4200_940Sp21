using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIW4200_940.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Luce's first MVC app.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information for Thom Luce.";

            return View();
        }
    }
}