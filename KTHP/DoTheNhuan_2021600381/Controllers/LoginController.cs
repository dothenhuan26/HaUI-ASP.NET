using DoTheNhuan_2021600381.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoTheNhuan_2021600381.Controllers
{
    public class LoginController : Controller
    {
        QLNVDB db = new QLNVDB();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string ma, string password)
        {
            var nv = db.NhanViens.Where(x => x.Manv.ToString() == ma && x.Matkhau == password).FirstOrDefault();
            if (nv == null)
            {
                ViewBag.errLogin = "Mã hoặc mật khẩu không chính xác!";
                return View("Index");
            }
            else
            {
                Session["ma"] = ma;
                return RedirectToAction("Index", "Management");
            }
        }

        public ActionResult Logout()
        {
            Session["ma"] = null;
            return RedirectToAction("Index", "Management");
        }
    }
}