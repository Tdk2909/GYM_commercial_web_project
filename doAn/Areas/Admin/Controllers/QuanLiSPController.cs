using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doAn.Models;
namespace QuanTri.Areas.Admin.Controllers
{
    public class QuanLiSPController : Controller
    {
        [HttpGet]
        // GET: Admin/QuanLiSP
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(String maSP)
        {
            DuLieu2Entities2 db = new DuLieu2Entities2();
            SanPham x = db.SanPhams.Find(maSP);
            db.SanPhams.Remove(x);
            db.SaveChanges();
            ViewData["SP"] = db.SanPhams.OrderBy(t => t.maSP).ToList<SanPham>();
            return View();
        }
    }
}