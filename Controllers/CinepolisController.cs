using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS904ASP.Models;

namespace IDGS904ASP.Controllers
{
    public class CinepolisController : Controller
    { 
        public ActionResult Index()
        {
            return View(new Boletos());
        }

        [HttpPost]
        public ActionResult Index(Boletos b)
        {
            b.CalcularProceso();
            return View(b);
        }
    }
}