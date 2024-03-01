using Pro_combobox_ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pro_combobox_ajax.Controllers
{
    public class HomeController : Controller
    {

        private DiaChiDB db = new DiaChiDB();



        public ActionResult Index()
        {
            ViewBag.tinh = db.Tinhs.ToList();
            //ViewBag.huyen = db.Huyens.ToList();
            //ViewBag.xa = db.Xas.ToList();
            return View();
        }

       
        public ActionResult loadHuyen(int tinhid)
        {
            return Json(db.Huyens.Where(s => s.TinhID == tinhid).Select(s => new
            {
                id = s.HuyenID,
                name = s.TenHuyen
            }).ToList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult loadXa(int huyenid)
        {
            return Json(db.Xas.Where(s => s.HuyenID == huyenid).Select(s => new
            {
                id = s.XaID,
                name = s.TenXa
            }).ToList(), JsonRequestBehavior.AllowGet);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}