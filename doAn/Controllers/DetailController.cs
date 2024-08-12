using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doAn.Models;
using doAn.Controllers;
namespace doAn.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail 
        public ActionResult Index(string maSP)
        {
            DuLieu2Entities2 db = new DuLieu2Entities2();
            SanPham s = db.SanPhams.Where(ms => ms.maSP.Equals(maSP)).First<SanPham>();
            ViewData["SP"] = s;      
            return View();
        }
           
    }
}