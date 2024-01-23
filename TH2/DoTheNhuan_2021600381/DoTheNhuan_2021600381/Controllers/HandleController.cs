using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoTheNhuan_2021600381.Controllers
{
    public class HandleController : Controller
    {
        // GET: Handle
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayTime()
        {
            return View();
        }

        public ActionResult Caculate()
        {
            return View();
        }

        public ActionResult HandleCaculate()
        {
            string calc = Request.Form["button"];
            double so1 = double.Parse(Request.Form["first_number"]);
            double so2 = double.Parse(Request.Form["second_number"]);

            double res = 0;

            switch (calc)
            {
                case "+":
                    res = so1 + so2;
                    break;
                case "-":
                    res = so1 - so2;
                    break;
                case "*":
                    res = so1 * so2;
                    break;
                case "/":
                    res = so1 / so2;
                    break;
            }
            ViewBag.firstNumber = so1;
            ViewBag.secondNumber = so2;
            ViewBag.res = res;
            return View("Caculate");
            //ViewBag.calc = Request.Form["button"];
            //return View();
        }

        public ActionResult RegisterForm()
        {
            return View();
        }

        public ActionResult HandleRegister()
        {
            ViewBag.first_name = Request.Form["first_name"];
            ViewBag.last_name = Request.Form["last_name"];
            ViewBag.email = Request.Form["email"];
            ViewBag.password = Request.Form["password"];
            ViewBag.city = Request.Form["city"];
            ViewBag.gender = Request.Form["gender"];
            return View();
        }

    }
}