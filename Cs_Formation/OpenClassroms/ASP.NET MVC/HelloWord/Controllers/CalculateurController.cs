using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWord.Controllers
{
    public class CalculateurController : Controller
    {
        //GET: Calculateur

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Ajouter(int valeur1, int valeur2)
        {
            int result = valeur1 + valeur2;
            return result.ToString();
        }
        public string Soustraire(int valeur1, int valeur2)
        {
            //int result = valeur1 - valeur2;
            //return result.ToString();

            return (valeur1 - valeur2).ToString();

        }
    }
}
