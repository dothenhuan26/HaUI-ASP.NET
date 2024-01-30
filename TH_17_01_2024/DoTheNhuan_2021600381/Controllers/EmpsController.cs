using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoTheNhuan_2021600381.Models;

namespace DoTheNhuan_2021600381.Controllers
{
    public class EmpsController : Controller
    {
        // GET: Emps
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HandleForm(Employee e)
        {
            return View(e);
        }

    }
}