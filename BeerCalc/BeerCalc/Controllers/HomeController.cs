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

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Tekst = DateTime.Now.Hour > 12 ? "Witamy :)" : "Masz zamiar pić przed 12? To znaczy, że powinieneś do nas dołączyć! :)";
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
            if (ModelState.IsValid)
            {
                daneOsoby.Score = Math.Ceiling((daneOsoby.Height * 0.12) + (daneOsoby.Age * 0.3) + (daneOsoby.Weight*0.4) + (daneOsoby.Expierience * 0.15));
                return View("Wyniki", daneOsoby);
            }
            else return View();
        }




    }
}