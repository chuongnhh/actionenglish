using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionEnglish.Areas.Coach.Controllers
{
    public class HomeController : Controller
    {
        // GET: Coach/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}