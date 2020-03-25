using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWord.Controllers
{
    public class MeteoController : Controller
    {
        // GET: Meteo
        public ActionResult Index()
        {
            return View();
        }

        public string Afficher(int jour, int mois, int annee)
        {
            return "Aujourd'hui nous sommme le: " + jour + "/" + mois + "/" + annee;
        }

    }
}