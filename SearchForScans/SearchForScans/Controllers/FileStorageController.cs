using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchForScans.Controllers
{
    public class FileStorageController : Controller
    {
        // GET: FileStorage
        public ActionResult Index()
        {
            return View();
        }

        // GET: FileStorage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FileStorage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FileStorage/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FileStorage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FileStorage/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FileStorage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FileStorage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
