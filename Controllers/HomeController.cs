using GacXep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GacXep.Controllers
{
    public class HomeController : Controller
    {
        DBGacXepBookstoreEntities db = new DBGacXepBookstoreEntities();
        public ActionResult Index()
        {
            var booksDetail = db.BookDetails;
            return View(booksDetail.ToList());
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
        
        public ActionResult FAQ()
        {
            return View();
        }

        public PartialViewResult _NewArrivalsPartial()
        {
            var booksDetail = db.BookDetails.ToList();
            return PartialView(booksDetail);
        }
    }
}