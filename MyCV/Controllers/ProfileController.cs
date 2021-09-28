using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCV.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Bio()
        {
            ViewBag.FirstName = "Strig";
            ViewBag.LastName = "Palma";
            ViewBag.DOB = "24-08-1998";
            ViewBag.Religion = "Christian";
            ViewBag.Email = "strigpalma@gmail.com";
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult References()
        {
            return View();
        }
    }
}