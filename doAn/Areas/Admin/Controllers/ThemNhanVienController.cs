using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doAn.Models;
using doAn.Controllers;
using System.IO;
namespace QuanTri.Areas.Admin.Controllers
{
    public class ThemNhanVienController : Controller
    {
        [HttpGet]
        // GET: Admin/QuanLiNV
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]


        public ActionResult Index(TaiKhoan x, HttpPostedFileBase HinhDaiDien)
        {
            if (HinhDaiDien != null)
            {
                string virPath = "/AssetsPrivate/images/";
                string phyPath = Server.MapPath("~/" + virPath);
                string ext = Path.GetExtension(HinhDaiDien.FileName);
                string tenF = "HDD" + ext;
                HinhDaiDien.SaveAs(phyPath + tenF);
                x.hinhDD = virPath + tenF;
            }
            else
                x.hinhDD = "";
            DuLieu2Entities2 db = new DuLieu2Entities2();

            db.TaiKhoans.Add(x);
            db.SaveChanges();
            ViewData["NV"] = db.TaiKhoans.OrderBy(t => t.taiKhoan1).ToList<TaiKhoan>();
            return View();
        }
    }
}
