using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doAn.Models;
namespace QuanTri.Areas.Admin.Controllers
{
    public class QuanLiNVController : Controller
    {   
        [HttpGet]
        // GET: Admin/QuanLiNV
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(String taiKhoan)
        {
            DuLieu2Entities2 db = new DuLieu2Entities2();
            TaiKhoan x = db.TaiKhoans.Find(taiKhoan);
            db.TaiKhoans.Remove(x);
            db.SaveChanges();
            ViewData["NV"] = db.TaiKhoans.OrderBy(t => t.taiKhoan1).ToList<TaiKhoan>();
            return View();
        }
    }
}