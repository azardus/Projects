using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OdeToFood.Data.Services;
using OdeToFood.Data.Models;

namespace OdeToFood.Web.Api
{
    /**
     *      Controleurs qui retournent du XML et su JSon
     * 
     */
    public class RestaurantsController : ApiController
    {
        private readonly IRestaurantData db;

        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }

        //[System.Web.Http.HttpGet]
        public IEnumerable<Restaurant> GetAll()
        {
            var model = db.GetAll();
            return model;
        }

        //  Test de retour
        //public string Get()
        //{
        //    return "Hello jeremie";
        //}
    }
}
