using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RS.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Not Found Error Page
        public ActionResult NotFoundError()
        {
            return View();
        }
    }
}