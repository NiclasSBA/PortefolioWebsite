using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portefolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My values";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "I'm so excited that you reached this page!";

            return View();
        }
        public ActionResult Experiences()
        {
            ViewBag.Message = "List of tips";
            return View();

        }
        public FilePathResult Niclas_Resume(string fileName)
        {
            return new FilePathResult(string.Format(@"~\Files\{0}", fileName + ".pdf" ), "application/pdf");
        }
    }
}