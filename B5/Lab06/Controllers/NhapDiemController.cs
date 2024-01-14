using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab06.Models;
namespace Lab06.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(SinhVien sv)
        {
            string path = Server.MapPath("~/StudentInfo.txt");
            string[] lines = { sv.Id, sv.Name, sv.Mark.ToString() };
            System.IO.File.WriteAllLines(path, lines);
            ViewBag.HanhDong = "Da ghi tu file!";

            return View("Index");
        }

        public ActionResult Open(SinhVien sv)
        {
            string path = Server.MapPath("~/StudentInfo.txt");
            string[] lines = System.IO.File.ReadAllLines(path);
            sv.Id = lines[0];
            sv.Name = lines[1];
            sv.Mark = double.Parse(lines[2]);
            ViewBag.ThongTin = "Ma sinh vien: " + sv.Id + " - Ho ten: " + sv.Name + " - Diem: " + sv.Mark;
            ViewBag.HanhDong = "Da doc tu file!";


            return View("Index", sv);
        }

    }
}