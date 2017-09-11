using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UPSCOApplicationServiceCenter.Models;

namespace UPSCOApplicationServiceCenter.Controllers
{
    public class ApplicationsController : Controller
    {
        // GET: Applications
        sbContext app = new sbContext();

        public ActionResult Index()
        {

            var sortedList = SortApplicationEntries();

            return View(sortedList.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateWithSupportAssigned()
        {
            List<object> myModel = new List<object>();
            myModel.Add(app.Applications.ToList());
            myModel.Add(app.LinkTables.ToList());
            myModel.Add(app.Users.ToList());

            return View(myModel);
        }

        [HttpPost]
        public ActionResult CreateWithSupportAssigned(Application newApp, LinkTable assignMentValues, User assignedUser)
        {
            if (ModelState.IsValid)
            {
                app.Users.Add(assignedUser);
                app.LinkTables.Add(assignMentValues);
                app.Applications.Add(newApp);
                app.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newApp);
        }

        [HttpPost]
        public ActionResult Create(Application newApp)
        {
            if (ModelState.IsValid)
            {
                app.Applications.Add(newApp);
                app.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newApp);
        }


        // GET: Applications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Application thisApp = app.Applications.Find(id);
     
            return View(thisApp);
        }

        public IEnumerable<Application> SortApplicationEntries()
        {
            var results = this.app.Applications.Where(g => g.id >= 1)
                .AsEnumerable()
                .OrderBy(g => g.applicationName).ThenBy(g => g.applicationModule);
            return results;
        }

        

    }
}