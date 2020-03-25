using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using HelloWord.Models;

namespace HelloWord.Controllers
{
    public class HomeController : Controller
    {

        /**
         *  L'action renvoie un objet ActionResult  en appelant la méthode View() , héritée de la classe Controller  du framework MVC
         *  
         *   La methode Vew() appelle la Views (cshtml) qui à le même nom de la définition du controller.
         */
        //public string Index(int? id)
        //{
        //    return "HomeController.Index" + id;
        //}

        // Renverra la chaîne HTML suivante : <a href="/Home/Afficher/123">Mon lien</a>
        public string Index(string id)
        {
            return HtmlHelper.GenerateLink(Request.RequestContext, RouteTable.Routes, "Mon lien", null, "Afficher", "Home", new RouteValueDictionary { { "id", id } }, null);
        }

        //  GET: Home
        //public ActionResult Index()
        //{
        //    //return View();
        //    return View("Index");
        //}


        //public ActionResult Index(string id)
        //{
        //    if (string.IsNullOrWhiteSpace(id))
        //        return View("Error");
        //    else
        //    {
        //        ViewData["Nom"] = id;
        //        // ViewBag.Nom = id;
        //        return View();
        //    }
        //}

        public ActionResult ListeClients()
        {
            Clients clients = new Clients();
            ViewData["Clients"] = clients.ObtenirListeClients();
            return View();
        }


        public ActionResult ChercherClient(string id)
        {
            ViewData["Nom"] = id;
            Clients clients = new Clients();
            Client client = clients.ObtenirListeClients().FirstOrDefault(c => c.Nom == id);
            if (client != null)
            {
                ViewData["Age"] = client.Age;
                return View("Trouver");
            }
            else
                return View("NonTrouver");

        }

    }


}