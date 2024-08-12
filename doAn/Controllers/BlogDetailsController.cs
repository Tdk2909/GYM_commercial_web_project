using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doAn.Models;
namespace doAn.Controllers
{
    public class BlogDetailsController : Controller
    {
        // GET: BlogDetails
        public ActionResult Index(string mabv)
        {
            DuLieu2Entities2 db = new DuLieu2Entities2();
            BaiViet cc = db.BaiViets.Where(l => l.maBV.Equals(mabv)).First<BaiViet>();
            ViewData["BV"] = cc;
            return View();
        }
    }
}