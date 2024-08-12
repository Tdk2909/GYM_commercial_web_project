using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doAn.Models;
namespace doAn.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        [HttpGet]
        public ActionResult Index()
        {
            CartShop gh = Session["GioHang"] as CartShop;
            ViewData["Cart"] = gh;
            return View();
        }

        public ActionResult Increase(string maSP)
        {
            CartShop gh = Session["GioHang"] as CartShop;
            gh.addItem(maSP);
            Session["GioHang"] = gh;
            return RedirectToAction("Index");
        }
        public ActionResult Decrease(string maSP)
        {
            CartShop gh = Session["GioHang"] as CartShop;
            gh.decrease(maSP);
            Session["GioHang"] = gh;
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string maSP)
        {
            CartShop gh = Session["GioHang"] as CartShop;
            gh.deleteItem(maSP);
            Session["GioHang"] = gh;
            return RedirectToAction("Index");
        }

    }
}