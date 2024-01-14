using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using B5._2.Models;

namespace B5._2.Controllers
{
    public class MailController : Controller
    {
        // GET: Mail
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MailInfo model)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(model.From);
                mail.To.Add(model.To);
                mail.Subject = model.Subject;
                mail.Body = model.Body;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("smtp.mail.yahoo.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(model.From, model.Password);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
            return RedirectToAction("Index", "Mail");
        }
    }
}