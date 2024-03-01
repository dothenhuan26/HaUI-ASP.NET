using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proj_ajax.Controllers
{
    public class AjaxDemo2LoginController : Controller
    {
        // GET: AjaxDemo2Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Login(string username, string password)
        {
            string rs = "";
            if (username.Equals(password))
            {
                rs = "Login is success, Hello " + username;
            }
            else
            {
                rs = "Invalid username or password";
            }
            return rs;
        }
    }
}