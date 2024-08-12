using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doAn.Models;

namespace doAn.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        // GET: Category
        public ActionResult Index(int maloai)
        {
            DuLieu2Entities2 db = new DuLieu2Entities2();
            SanPham x = db.SanPhams.Where(l => l.maLoai.Equals(maloai)).First<SanPham>();
            ViewData["LSP"] = x;
            return View();
        }
        



    }
}