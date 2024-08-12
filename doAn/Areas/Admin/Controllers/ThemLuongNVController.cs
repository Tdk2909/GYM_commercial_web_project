using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doAn.Models;
using doAn.Controllers;
namespace QuanTri.Areas.Admin.Controllers
{
    public class ThemLuongNVController : Controller
    {
        [HttpGet]
        // GET: Admin/QuanLiNV
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]


        public ActionResult Index(TaiKhoan x)
        {   DuLieu2Entities2 db = new DuLieu2Entities2();

            db.TaiKhoans.Add(x);
            db.SaveChanges();
            ViewData["Luong"] = db.TaiKhoans.OrderBy(t => t.taiKhoan1).ToList<TaiKhoan>();
            return View();
        }
    }
}
