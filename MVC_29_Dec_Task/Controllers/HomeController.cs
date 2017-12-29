using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_29_Dec_Task.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Welcome(string id)
        {
            TempData["value"] = id;
            TempData.Keep("value");
            return View();
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}