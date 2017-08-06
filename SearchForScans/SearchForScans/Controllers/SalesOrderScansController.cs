using SearchForScans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchForScans.Controllers
{
    public class SalesOrderScansController : Controller
    {
       DocScanArchiveEntities soContext = new DocScanArchiveEntities();

        public ActionResult Index(string searchBy)
        {
            if (searchBy != null)
            {
                return View(soContext.SalesOrderArchives.Where(x => x.SalesOrderNumber.Contains(searchBy) ||
                 x.VendorName.Contains(searchBy)).ToList());
            }
            else {

                return View(soContext.SalesOrderArchives.OrderByDescending(s => s.ScanDate).Take(30));
            }

        }

        public ActionResult Details(int Id)
        {
            SalesOrderArchive wo = soContext.SalesOrderArchives.Find(Id);       
                        
            return View(wo);
        }
        
    }
}