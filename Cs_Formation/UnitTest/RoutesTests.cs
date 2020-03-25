using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using HelloWord;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTest
{
    [TestClass]
    public class RoutesTests
    {
        private static RouteData DefinirUrl(string url)
        {
            // 1- Nous allons créer un faux objet HttpContextBase afin de définir l’URL que nous voulons tester
            Mock<HttpContextBase> mockContext = new Mock<HttpContextBase>();

            // 2- Nous bouchonnons la propriété AppRelativeCurrentExecutionFilePath car c’est cette propriété qui est utilisée par le routing.
            mockContext.Setup(c => c.Request.AppRelativeCurrentExecutionFilePath).Returns(url);

            // 3- Nous pourrons alors instancier un objet RouteCollection et le passer en paramètres de notre méthode de configuration :
            RouteCollection routes = new RouteCollection();

            RouteConfig.RegisterRoutes(routes);

            // 4- Nous appellons la méthode GetRouteData  pour effectuer le mapping à partir de l’URL contenue dans l’objet de type HttpContextBase
            RouteData routeData = routes.GetRouteData(mockContext.Object);

            return routeData;
        }

        [TestMethod]
        public void Home_RouteTest_returnHomeController()
        {
            RouteData routeData = DefinirUrl("~/Home/Index/2");

            // 5- Et enfin, nous n’aurons plus qu’à vérifier que tout est correct, en allant inspecter l’objet routeData
            Assert.IsNotNull(routeData);
            Assert.AreEqual("Home", routeData.Values["controller"]);
            Assert.AreEqual("Index", routeData.Values["action"]);
            Assert.AreEqual("2", routeData.Values["id"]);
        }

        [TestMethod]
        public void Routes_HomePage_Return_controllerHomeEtMethodeIndex()
        {
            RouteData routeData = DefinirUrl("~/");

            Assert.AreEqual("Home", routeData.Values["controller"]);
            Assert.AreEqual("Index", routeData.Values["action"]);
            Assert.AreEqual(UrlParameter.Optional, routeData.Values["Id"]);
        }

        [TestMethod]
        public void Routes_MeteoAuJourdhui_ReturnControllerMeteoMethodeAfficherEtParameterAujourdhui()
        {
            DateTime dateTime = DateTime.Now;
            RouteData routeData = DefinirUrl(string.Format("~/{0}/{1}/{2}", dateTime.Day, dateTime.Month, dateTime.Year));
            Assert.IsNotNull("routeData");
            Assert.AreEqual("Meteo", routeData.Values["controller"]);
            Assert.AreEqual("Afficher", routeData.Values["action"]);
            Assert.AreEqual("Afficher", routeData.Values["action"]);
            Assert.AreEqual(dateTime.Day.ToString(), routeData.Values["jour"]);
            Assert.AreEqual(dateTime.Month.ToString(), routeData.Values["mois"]);
            Assert.AreEqual(dateTime.Year.ToString(), routeData.Values["annee"]);
        }

        [TestMethod]
        public void Routes_UrlBidon_RetournNull()
        {
            RouteData routeData = DefinirUrl("/Url/Bidon/pasBonne");
            Assert.IsNull(routeData);

        }
    }
}
