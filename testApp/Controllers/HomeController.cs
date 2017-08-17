using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testApp.Models;

namespace testApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult metroTransitInfo()
        {
            return View();
        }

        public ActionResult TransitInfo()
        {
            return View();
        }

        public JsonResult GetTransitInfo()
        {
            Transit tran = new Transit();
            return Json(tran.getMetroTransitInfo(), JsonRequestBehavior.AllowGet);
        }
       
    }
}