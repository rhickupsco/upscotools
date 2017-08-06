using SearchForScans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchForScans.Controllers
{
    public class WorkOrderScansController : Controller
    {

        DocScanArchiveEntities woContext = new DocScanArchiveEntities();

        public ActionResult Index(string searchBy)
        {
            if (searchBy != null)
            {
                return View(woContext.WorkOrderArchives.Where(x => x.ParentWorkOrderNumber.Contains(searchBy) ||
                x.ItemNumber.Contains(searchBy) || x.ItemDescription.Contains(searchBy) ||
                x.WorkOrderNumber.Contains(searchBy) || x.SalesOrderNumber.Contains(searchBy) 
                || x.VendorName.Contains(searchBy)).ToList());
            }
            else
            {
                return View(woContext.WorkOrderArchives.OrderByDescending(x => x.ScanDate).Take(30));
            }

        }

        public ActionResult Details(int Id)
        {
            WorkOrderArchive wo = woContext.WorkOrderArchives.Find(Id);
            return View(wo);
        }
    }
}