using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchForScans.Controllers
{
    public class PDFImageController : Controller
    {
        // GET: PDFImage
        public ActionResult Index(int Id)
        {
           Models.DocScanArchiveEntities dbe = new Models.DocScanArchiveEntities();

           var pdf = dbe.FileStorages.Find(Id);
            return View(pdf);

        }

        public ActionResult DisplayPDF(int Id)
        {
            Models.DocScanArchiveEntities dbe = new Models.DocScanArchiveEntities();
            var pdf = dbe.FileStorages.Find(Id);

            byte[] byteArray = pdf.File;
            MemoryStream pdfStream = new MemoryStream();
            pdfStream.Write(byteArray, 0, byteArray.Length);
            pdfStream.Position = 0;
            return new FileStreamResult(pdfStream, "application/pdf");
        }

        public ActionResult Notes(int Id)
        {
            Models.DocScanArchiveEntities dbe = new Models.DocScanArchiveEntities();
            var pdf = dbe.FileStorages.Find(Id);
            return PartialView("_Notes");
        }
        
    }
}