using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProjectNight.Controllers
{
    public class PdfController : Controller
    {
        // GET: Pdf
        public ActionResult ShowPdf()
        {
            // PDF dosyasının yolu (örnek olarak "pdfs" klasöründeki "sample.pdf")  //View klasorunune mumkun mertebe bırakmayın.
            string filePath = Server.MapPath("~/Content/cv.pdf");

            // PDF dosyasını byte dizisi olarak oku
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);

            // PDF dosyasını tarayıcıda görüntüle
            return File(fileBytes, "application/pdf");
        }
    }
}
