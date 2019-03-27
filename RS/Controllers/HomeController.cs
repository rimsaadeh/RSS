using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RS.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home page
        public ActionResult Index()
        {
            return View();
        }

        // GET: About page
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // GET: Contact page
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}