using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doAn.Models;
namespace QuanTri.Areas.Admin.Controllers
{
    public class TrangChuController : Controller
    {
        // GET: Admin/TrangChu
        DuLieu2Entities2 db = new DuLieu2Entities2();
        public ActionResult Index(KhachHang k)
        {
            
            return View();

        }
    }
}