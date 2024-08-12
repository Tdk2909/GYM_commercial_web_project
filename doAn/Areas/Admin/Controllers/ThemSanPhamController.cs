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
    public class ThemSanPhamController : Controller
    {
        [HttpGet]
        // GET: Admin/QuanLiNV
        public ActionResult Index()
        {
            List<SanPham> l = new DuLieu2Entities2().SanPhams.OrderBy(z => z.tenSP).ToList<SanPham>();
            ViewData["SP"] = l;
            return View();
        }
        [HttpPost]
        public ActionResult Index(SanPham x, HttpPostedFileBase HinhDaiDien)
        {
            if (HinhDaiDien != null)
            {
                string virPath = "/AssetsPublic/images/products/Men/";
                string phyPath = Server.MapPath("~/" + virPath);
                string ext = Path.GetExtension(HinhDaiDien.FileName);
                string tenF = "HDD" + ext;
                HinhDaiDien.SaveAs(phyPath + tenF);
                x.hinhDD = virPath + tenF;
            }
            else
                x.hinhDD = "";
            DuLieu2Entities2 db = new DuLieu2Entities2();
            db.SanPhams.Add(x);
            db.SaveChanges();
            ViewData["SP"] = db.SanPhams.OrderBy(t => t.maSP).ToList<SanPham>();
            return View();
        }
    }
}
