using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string Acc, string Pass)
        {
            bool isAuthentic = (Acc != null && Pass != null && Acc.Equals("admin") && Pass.Equals("123456"));
            if (isAuthentic)
                return View("~/Areas/Admin/Views/TrangChu/Index.cshtml");
            return View();
        }
    }
}