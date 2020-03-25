using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HelloWord
{
    /*******************
     *      Logique de configuration, sert à configurer l’application.
     *      
     *      controller  = Home      = HomeController
     *      action      = Index     = Method of Controller
     *      id          = null      = Parameter
     *      
     *      Ceci a pour effet d’instancier le contrôleur HomeController  et d’exécuter la méthode Index
     *      
     *      En MVC, lorsque vous naviguez sur une URL, ce n’est pas un fichier que vous tentez d’afficher, non. Vous tentez d’exécuter une action d’un contrôleur !
     *      
     *      1-Le contrôleur est une classe qui dérive de la classe de base Controller  et dont les méthodes reflètent les actions faites par l’utilisateur.
     *      
     *      2-La vue peut combiner facilement des balises HTML et du code C#, pour par exemple afficher des informations remontées par le contrôleur grâce à l’objet ViewData .
     *      
     *      3-Le modèle est exploité par le contrôleur et transmis à la vue pour être affiché.
     ******************************************/

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //name: "Default",
            //url: "{controller}/{action}/{id}",

            // defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }          // ok
            // defaults: new { controller = "Home", action = "Error", id = UrlParameter.Optional }          // ok
            // defaults: new { controller = "Home", action = "Index", id = 123}                             // ok

            // defaults: new { controller = "Home", action = "ListeClients", id = UrlParameter.Optional}     // ok
            // defaults: new { controller = "Home", action = "ChercherClient", id = "Papa" }                // ok

            //Créations des routes:
            //---------------------
            //1- Different type de URL:
            //---------------------------
            //name: "Default",
            //url: "{action}/{valeur1}/{valeur2}",                                                             //ok
            //url: "{Controller}/{action}/{valeur1}/{valeur2}",                                                //ok
            //defaults: new { controller = "Calculateur", action = "Ajouter", valeur1 = 5, valeur2 = 5 }       //ok
            //2- Url 2:
            //---------
            //name: "Default",
            ////url: "{Controller}/Calculatrise-{action}/{valeur1}/{valeur2}",                                      // NOK ms OK en tapant ds la nav
            //url: "{Controller}/{action}/{valeur1}/{valeur2}",                                                   //  OK 
            //defaults: new { controller = "Calculateur", action = "Soustraire", valeur1 = 10, valeur2 = 5 }      //ok
            //);

            /**********************
             * D’une manière générale, il faut toujours commencer par ajouter la route la plus spécifique pour finir par la plus générale.
             * 
             * Si nous inversons l’ordre des deux routes, sur la requête /Ajouter/4/7, ASP.NET MVC va tenter d’instancier le contrôleurAjouter  qui n’existe pas et ceci va provoquer une erreur qui empêchera la route suivante d’être analysée.
             *****************************************/


            routes.MapRoute(
                name: "Meteo",
                url: "{jour}/{mois}/{annee}",
                defaults: new { Controller = "Meteo", Action = "Afficher" },
                constraints: new { jour = @"\d+", mois = @"\d+", annee = @"\d{4}" }
                );

            routes.MapRoute(
                 name: "Ajouter",
                 url: "Ajouter/{valeur1}/{valeur2}",
                 defaults: new { controller = "Calculateur", action = "Ajouter" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
               name: "RouteAttrapeTout",
               url: "{controller}/{action}/{*id}",
               defaults: new { controller = "Accueil", action = "Index", id = UrlParameter.Optional }
                );
   

        }
    }
}
