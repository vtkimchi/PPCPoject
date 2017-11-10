using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPcRentalProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sơn đẹp trai quá";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "ABC XYZggg";

            return View();
        }
       
    }
}