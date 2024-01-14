using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using B4._2.Models;

namespace B4._2.Controllers
{
    public class TinhTienDienController : Controller
    {
        // GET: TinhTienDien
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(HoaDon hd)
        {
            return View("Result", hd);
        }
    }
}