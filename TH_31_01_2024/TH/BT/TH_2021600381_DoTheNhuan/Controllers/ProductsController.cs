using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TH_2021600381_DoTheNhuan.Models;

namespace TH_2021600381_DoTheNhuan.Controllers
{
    public class ProductsController : Controller
    {
        private ECartDB2 db = new ECartDB2();

        // GET: Products
        public ActionResult Index(string searchString)
        {
            var products = db.Products.Select(p => p);
            if (!String.IsNullOrEmpty(searchString))
            {
                String x = Request.Form["searchtype"];
                if (x == "pname")
                {
                    products = db.Products.Where(p => p.ProdName.Contains(searchString));
                }
                else
                {
                    int searchInt = int.Parse(searchString);
                    products = db.Products.Where(p => p.Price < searchInt);
                }
            }


            ViewBag.ds2 = db.Products.OrderByDescending(p => p.Pid).Take(10).ToList();
            ViewBag.ds3 = db.Products.OrderByDescending(p => p.Price).Take(10).ToList();

            return View(products.ToList());
        }


        [Route("shop/danhmuc/{Categoryid?}")]
        public ActionResult ProductByCategoryID(int Categoryid)
        {
            ViewBag.CategoryName = db.Categories.Where(c => c.Categoryid == Categoryid).SingleOrDefault().CategoryName;
            return View(db.Products.Where(p => p.Categoryid == Categoryid).ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Pid,Categoryid,ProdName,MetaTitle,Description,ImagePath,Price")] Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    product.ImagePath = "";
                    var f = Request.Files["ImagePath"];
                    if (f != null && f.ContentLength > 0)
                    {
                        string FileName = System.IO.Path.GetFileName(f.FileName);
                        string UploadPath = Server.MapPath("~/Content/Images/" + FileName);
                        f.SaveAs(UploadPath);
                        product.ImagePath = FileName;
                    }
                    db.Products.Add(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {

            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Pid,Categoryid,ProdName,MetaTitle,Description,ImagePath,Price")] Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var f = Request.Files["ImagePath"];
                    if (f != null && f.ContentLength > 0)
                    {
                        string FileName = System.IO.Path.GetFileName(f.FileName);
                        string UploadPath = Server.MapPath("~/Content/Images/" + FileName);
                        f.SaveAs(UploadPath);
                        product.ImagePath = FileName;
                    }
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {

            }

            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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
