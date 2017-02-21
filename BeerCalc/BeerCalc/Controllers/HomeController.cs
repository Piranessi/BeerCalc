using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerCalc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Tekst = DateTime.Now.Hour > 12 ? "Witamy :)" : "Masz zamiar pić przed 12? To znaczy, że powinieneś do nas dołączyć! :)";
            return View();
        }
    }
}