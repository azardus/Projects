using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace OdeToFood.Web
{
    /**
     *      Création d'une classe de config
     *      
     *      qui a un container qui build les controllers et 
     *      
     *      build les listes de restaurant comme étant un singleton de type IRestaurantData
     * 
     */
    public static class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpconfiguration)
        {
            var builder = new ContainerBuilder();
            // Reference d'assembly du projet
            builder.RegisterControllers(typeof(MvcApplication).Assembly);  //Register MVC Controllers
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);  //Register WebApi Controllers
            //builder.RegisterType<InMemoryRestaurantData>()        //  Register to la bdd lacal en Singleton
            //    .As<IRestaurantData>()
            //    .SingleInstance();
            builder.RegisterType<SqlRestaurantData>()               // 1- Register to the model de la dbb ( get / update / create / deleate )
                .As<IRestaurantData>()
                .InstancePerRequest();
            builder.RegisterType<OdeToFoodDbContext>().InstancePerRequest();    //  2- Register to Real local db



            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));  //Set the MVC DependencyResolver
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver

        }
    }
}