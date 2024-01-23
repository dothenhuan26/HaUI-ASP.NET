using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoTheNhuan_2021600381.Models;


namespace DoTheNhuan_2021600381.Controllers
{
    public class CuaHangController : Controller
    {
        static List<CuonSach> list = new List<CuonSach>();
        static List<string> theloai = new List<string>() { "vh", "nn", "khkt", "tt" };

        public CuaHangController()
        {
            if (list.Count == 0)
            {
                for (int i = 1; i <= 10; i++)
                    list.Add(new CuonSach("Sach " + i, theloai.ElementAt((new Random()).Next(0, 3)), i * 50, 120 * i));
            }
        }



        // GET: CuaHang
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HandleForm(CuonSach cs)
        {

            //return View("Index", cs);
            list.Add(cs);
            return View(cs);
        }

        public ActionResult DisplayList()
        {

            ViewBag.Data = list;
            ViewBag.List2 = from cs in list where cs.SoLuong > 100 select cs;
            ViewBag.List3 = from cs in list where cs.GiaTien < 300 select cs;
            return View();
        }

        public ActionResult DisplayCuaHang()
        {
            CuaHang ch = new CuaHang("ch01", "Cua Hang 1", "Ha Noi", list);

            return View(ch);
        }

    }
}