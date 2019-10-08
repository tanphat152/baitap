using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace test_template.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           

            return View();
        }

        public ActionResult cart()
        {
            return View();
        }

        public ActionResult checkout()
        {
            return View();
        }

        public ActionResult checkout2()
        {
            return View();
        }

        public ActionResult contact()
        {
            return View();
        }

        public ActionResult details()
        {
            return View();
        }

        public ActionResult productgird()
        {
            return View();
        }

        public ActionResult productlitst()
        {
            return View();
        }
        public ActionResult checkout_partial()
        {
            return PartialView();
        }
        public ActionResult product_partial()
        {
            return PartialView();
        }
        public ActionResult trademark()
        {
            return PartialView();
        }
    }
}