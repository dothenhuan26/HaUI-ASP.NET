using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["haha"] = "hehe";

            return View();
        }

        public ActionResult About()
        {
            if (TempData["haha"] != null)
            {
                return RedirectToAction("Contact", "Home");
            }

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