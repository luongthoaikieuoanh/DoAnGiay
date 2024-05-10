using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuAn.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ViewData["title"] = "Sản phẩm";

            return View();
        }
        public ActionResult Details()
        {
            ViewData["title"] = "Chi tiết sản phẩm";

            return View();
        }
    }
}