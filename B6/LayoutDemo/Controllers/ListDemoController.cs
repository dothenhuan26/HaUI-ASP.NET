using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutDemo.Controllers
{
    public class ListDemoController : Controller
    {
        // GET: ListDemo
        public ActionResult Bullets()
        {
            return View();

        }
        public ActionResult Numbering()
        {
            return View();
        }
    }
}