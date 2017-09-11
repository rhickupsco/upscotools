using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UPSCOApplicationServiceCenter.Controllers
{
    public class HomeController : Controller
    {

        // GET: Applications
        sbContext app = new sbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Matrix()
        {
            var sortedList = from e in app.View_PowerUsersMatrix
                       orderby e.applicationName, e.applicationModule
                       select e;

            return View(sortedList);
        }

      
    }
}