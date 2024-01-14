using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab02.Models;

namespace Lab02.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(SinhVien sv)
        {
            sv.Id = "SV001";
            sv.Name = "Nguyen Anh Tuan";
            sv.Marks = 9.5;


            return View(sv);
        }

    }
}