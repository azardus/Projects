using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelloWorld/About
        public ActionResult About()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome?name=Jeremie&numtimes=4
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }


        // GET: /HelloWorld/  
        //      /HelloWorld/Index
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}

        //HttpUtility.HtmlEncode = Avant d'afficher des chaînes, appelez la méthode HtmlEncode . Les éléments HTML sont convertis en représentations de chaînes que le navigateur affichera plutôt que d'interpréter comme HTML.


        // GET: /HelloWorld/Welcome/    
        //      /HelloWorld/Welcome?name=Jeremie&id=4
        //public string Welcome(string name, int id = 1)
        //{
        //    return HttpUtility.HtmlEncode($"Hello {name}, ID: {id}");
        //}
    }
}