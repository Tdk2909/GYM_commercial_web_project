using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doAn.Models;
namespace QuanTri.Areas.Admin.Controllers
{
    public class QuanLiKhachHangController : Controller
    {
        // GET: Admin/QuanLiKhachHang
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(String maKH)
        {
            DuLieu2Entities2 db = new DuLieu2Entities2();
            KhachHang x = db.KhachHangs.Find(maKH);
            db.KhachHangs.Remove(x);
            db.SaveChanges();
            ViewData["KH"] = db.KhachHangs.OrderBy(t => t.maKH).ToList<KhachHang>();
            return View();
        }
    }
}