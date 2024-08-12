using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doAn.Models;
namespace QuanTri.Areas.Admin.Controllers
{
    public class ThemKhachHangController : Controller
    {
        // GET: Admin/ThemKhachHang
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(KhachHang x)
        {
            
                DuLieu2Entities2 db = new DuLieu2Entities2();
                db.KhachHangs.Add(x);
                db.SaveChanges();
                ViewData["KH"] = db.KhachHangs.OrderBy(t => t.maKH).ToList<KhachHang>();
                return View();
            
        }
    }
}