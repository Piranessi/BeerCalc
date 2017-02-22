using BeerCalc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerCalc.Controllers
{
    public class HomeController : Controller
    {
        private string Powitanie()
        {
            return DateTime.Now.Hour > 12 ? "Witamy :)" : "Masz zamiar pić przed 12? To znaczy, że powinieneś do nas dołączyć! :)";
        }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Tekst = Powitanie();
            return View();
        }


        [HttpGet]
        public ActionResult ZrobTest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ZrobTest(PersonDB daneOsoby)
        {
            if (ModelState.IsValid) return View("Wyniki", daneOsoby);
            else return View();
        }


    }
}