using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Bai5.Models;

namespace Bai5.Controllers
{
    public class NhapThongTinController : Controller
    {
        // GET: NhapThongTin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(NhanVien nv, HttpPostedFileBase avatar)
        {
            try
            {
                if (avatar.ContentLength > 0)
                {
                    string _assets = "/UploadedFiles";
                    string _filename = Path.GetFileName(avatar.FileName);
                    string _filepath = Path.Combine(Server.MapPath($"~{_assets}"), _filename);
                    avatar.SaveAs(_filepath);
                    string path = Server.MapPath("~/NhanVienInfo.txt");
                    nv.avatar = _assets + "/" + _filename;
                    string[] lines = { nv.id, nv.name, nv.birthday.ToString("yyyy-MM-dd"), nv.salary.ToString(), nv.avatar };

                    System.IO.File.WriteAllLines(path, lines);

                    ViewBag.UploadMessage = "Avatar Uploaded Successfully!";
                    ViewBag.SaveMessage = "Save to File Successfully!";
                    return View("Index");
                }
            }
            catch
            {
                ViewBag.UploadMessage = "Avatar Uploaded failded!";
                ViewBag.SaveMessage = "Save to File failed!";

                return View("Index");
            }
            return View("Index");
        }

        public ActionResult Open(NhanVien nv)
        {
            string path = Server.MapPath("~/NhanVienInfo.txt");
            string[] lines = System.IO.File.ReadAllLines(path);
            ViewBag.Id = lines[0];
            ViewBag.Name = lines[1];
            ViewBag.Birthday = lines[2];
            ViewBag.Salary = lines[3];
            ViewBag.Avatar = lines[4];
            //ViewBag.OpenMessage = lines[0] + "<br/>" + lines[1] + "<br/>" + lines[2] + "<br/>" + lines[3] + "<br/>" + lines[4];
            return View("Index", nv);
        }
    }
}