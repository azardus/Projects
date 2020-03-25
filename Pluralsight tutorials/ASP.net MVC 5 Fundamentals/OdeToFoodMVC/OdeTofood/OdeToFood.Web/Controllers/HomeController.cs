using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Data.Services;

namespace OdeToFood.Web.Controllers
{

    /**
     *      Controleurs qui retournent des vues HTML
     * 
     */
    public class HomeController : Controller
    {
        readonly IRestaurantData db;

        // Injection de dependance autofac pour supprimer du code en dûr
        public HomeController(IRestaurantData db)
        {
            this.db = db;
        }

        // 1 // Construction de l'acces a la bdd local grace au constructeur et la new l'intance
        //public HomeController()
        //{
        //    db = new InMemoryRestaurantData();
        //}

        // Recuperration de tous les restos que je passe dans la vue.
        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        // /Home/About
        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}