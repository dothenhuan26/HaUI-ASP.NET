using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab03.Models;

namespace Lab03.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Xuly()
        //{
        //    string Ma = Request.Form["Id"];
        //    string Ten = Request.Form["Name"];
        //    double Diem = double.Parse(Request.Form["Marks"]);
        //    ViewBag.Ma = Ma;
        //    ViewBag.Ten = Ten;
        //    ViewBag.Diem = Diem;
        //    return View();
        //}

        //public ActionResult Xuly(FormCollection data)
        //{
        //    string Ma = data["Id"];
        //    string Ten = data["Name"];
        //    double Diem = double.Parse(data["Marks"]);
        //    ViewBag.Ma = Ma;
        //    ViewBag.Ten = Ten;
        //    ViewBag.Diem = Diem;
        //    return View();
        //}

        //public ActionResult Xuly(string Id = "", string Name = "", Double Marks = 0)
        //{
        //    string Ma = Id;
        //    string Ten = Name;
        //    double Diem = Marks;
        //    ViewBag.Ma = Ma;
        //    ViewBag.Ten = Ten;
        //    ViewBag.Diem = Diem;
        //    return View();
        //}

        public ActionResult Xuly(SinhVien sv)
        {
            string Ma = sv.Id;
            string Ten = sv.Name;
            double Diem = sv.Marks;
            ViewBag.Ma = Ma;
            ViewBag.Ten = Ten;
            ViewBag.Diem = Diem;
            return View();
        }
    }
}