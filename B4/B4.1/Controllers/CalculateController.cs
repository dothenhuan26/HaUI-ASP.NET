using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B4._1.Controllers
{
    public class CalculateController : Controller
    {
        // GET: Calculate
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calc()
        {
            double a = double.Parse(Request.Form["SoA"]);
            double b = double.Parse(Request.Form["SoB"]);
            string calc = Request.Form["calc"] + "";

            switch (calc)
            {
                case "sum":
                    ViewBag.Res = a + b;
                    break;
                case "sub":
                    ViewBag.Res = a - b;
                    break;
                case "mul":
                    ViewBag.Res = a * b;
                    break;
                case "divide":
                    if (b != 0) ViewBag.Res = a / b;
                    else ViewBag.Res = "Khong chia duoc";
                    break;
            }
            return View();
        }


    }


}