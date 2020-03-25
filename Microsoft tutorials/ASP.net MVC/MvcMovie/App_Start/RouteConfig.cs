using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;




namespace MvcMovie
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            // GET: /HelloWorld/  ou  /HelloWorld/Index  ou  /HelloWorld/Welcome/ ou  /HelloWorld/Welcome?name=Jeremie&numtimes=4
            //  /Movies/Index
            );

            //routes.MapRoute(
            //    name: "Hello",
            //    url: "{controller}/{action}/{name}/{id}"
            //);
            //  /HelloWorld/Welcome?name=Jeremie&numtimes=4
            //  /HelloWorld/Welcome/Scott/3






        }
    }
}
