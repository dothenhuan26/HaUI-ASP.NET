using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proj_LuyenTap.Models;

namespace Proj_LuyenTap.Controllers
{
    public class LoginAccController : Controller
    {
        private CompanyContext db = new CompanyContext();

        // GET: LoginAcc
        public ActionResult Index()
        {
            return View(db.Accouts.ToList());
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = db.Accouts.Where(u => u.username == username && u.password == password).FirstOrDefault();

            if (user == null)
            {
                ViewBag.errMsg = "Sai tên đăng nhập hoặc mật khẩu.";
                return View();
            }
            else
            {
                Session["username"] = username;
                return RedirectToAction("Index", "Home");
            }

        }

        public ActionResult Logout()
        {
            Session["username"] = null;
            return RedirectToAction("Index", "Home");
        }

        // GET: LoginAcc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accout accout = db.Accouts.Find(id);
            if (accout == null)
            {
                return HttpNotFound();
            }
            return View(accout);
        }

        // GET: LoginAcc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginAcc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,username,password,role")] Accout accout)
        {
            if (ModelState.IsValid)
            {
                db.Accouts.Add(accout);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accout);
        }

        // GET: LoginAcc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accout accout = db.Accouts.Find(id);
            if (accout == null)
            {
                return HttpNotFound();
            }
            return View(accout);
        }

        // POST: LoginAcc/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,username,password,role")] Accout accout)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accout).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accout);
        }

        // GET: LoginAcc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accout accout = db.Accouts.Find(id);
            if (accout == null)
            {
                return HttpNotFound();
            }
            return View(accout);
        }

        // POST: LoginAcc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accout accout = db.Accouts.Find(id);
            db.Accouts.Remove(accout);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
