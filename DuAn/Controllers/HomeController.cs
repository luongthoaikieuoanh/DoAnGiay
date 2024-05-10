using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuAn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["title"] = "Trang chủ";
            return View();
        }
        
        [ChildActionOnly]//đây là con không phải là 1 trang riêng

        public ActionResult Navbar()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult Footer()
        {
            return PartialView();
        }

        public ActionResult About()
        {
            ViewData["title"] = "Giới thiệu";

            return View();
        }

        public ActionResult Contact()
        {
            ViewData["title"] = "Liên hệ";


            return View();
        }
    }
}