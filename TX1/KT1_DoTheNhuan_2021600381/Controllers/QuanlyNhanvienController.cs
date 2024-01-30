using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KT1_DoTheNhuan_2021600381.Models;

namespace KT1_DoTheNhuan_2021600381.Controllers
{
    public class QuanlyNhanvienController : Controller
    {
        // GET: QuanlyNhanvien
        public static List<Nhanvien> danhsach = new List<Nhanvien>();

        public QuanlyNhanvienController()
        {
            if (danhsach.Count() == 0)
            {
                danhsach.Add(new Nhanvien("Nv01", "Nguyễn Vân Anh", "Hà Nội", 15, 200000));
                danhsach.Add(new Nhanvien("Nv02", "Lê Thu Hà", "Hải Phòng", 27, 250000));
                danhsach.Add(new Nhanvien("Nv03", "Nguyễn Văn Hoàng", "Hà Nội", 18, 250000));
                danhsach.Add(new Nhanvien("Nv04", "Trần Thu Hương", "Hải Phòng", 25, 190000));
                danhsach.Add(new Nhanvien("Nv05", "Ngô Phương Thảo", "Quảng Ninh", 20, 180000));
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayList()
        {
            List<Nhanvien> l1 = danhsach.Where(x => x.songaylam < 20).ToList();
            List<Nhanvien> l2 = danhsach.Where(x => x.luongngay > 190000).ToList();
            
            ViewBag.l1 = l1;
            ViewBag.l2 = l2;

            return View();
        }

        public ActionResult AddNhanvien()
        {
            return View();
        }

        public ActionResult HandleAdd(Nhanvien nv)
        {
            danhsach.Add(nv);
            return RedirectToAction("Detail", nv);
        }

        public ActionResult Detail(Nhanvien nv)
        {
            return View(nv);
        }


    }
}