using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            //var name = HttpContext.Request.QueryString["name"];

            model.Name = name ?? "Pas de parameter ?NAME=\"quelque chose..\" dans l'URL.";

            model.Message = ConfigurationManager.AppSettings["message"];
            
            return View(model);
        }
    }
}