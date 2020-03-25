using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{ Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italien},
                new Restaurant{ Id = 2, Name = "Tersiguels", Cuisine = CuisineType.French},
                new Restaurant{ Id = 3, Name = "Mango Grove", Cuisine = CuisineType.Indian},
            };
        }

        public void Add (Restaurant OtherRestaurant)
        {
            restaurants.Add(OtherRestaurant);
            OtherRestaurant.Id = restaurants.Max(r => r.Id)+ 1;
        }

        public void Delete(int? id)
        {
            var elementToRemove = Get(id);
            if(elementToRemove != null)
            {
                restaurants.Remove(elementToRemove);
            }
            
        }

        /// <summary>
        ///  Action du model me permettant de retourner l'id du retaurant courant
        /// </summary>
        public Restaurant Get(int? id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        // Action du model me permettant de retourner tous les Names des restaurants.
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        // Action du model qui me permet de modiffier un restaurant
        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.Id);
            if (existing != null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;
            }
            //var resto = Get(id); 
            //this.restaurants.u= resto.Name;
            //Cuisine = cuisine;
            //throw new NotImplementedException();
        }
    }
}
