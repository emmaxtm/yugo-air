using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Aero klub Yugo Air";
            ViewBag.Description = "Letite kao profesionalac i ostvarite svoj san!";
            ViewBag.Keywords = "letenje, jedrilica, obuke i treninzi";
            return View();
        }

       [HttpGet]
        public ActionResult Obrazac()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Obrazac(Models.Kandidat rezultat)
        {
            return View("Rezultat", rezultat);
        }
        [HttpGet]
        public ActionResult Obrazac2()
        {
            return View();
        }
        
        
        public ActionResult O_nama()
        {
            ViewBag.Title = "Aero klub Yugo Air";
            ViewBag.Message = "O nama";

            return View();
        }
    }
}