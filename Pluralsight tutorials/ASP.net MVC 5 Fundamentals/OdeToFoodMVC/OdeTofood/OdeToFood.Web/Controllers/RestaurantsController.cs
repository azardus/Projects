using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantData db;

        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }

        // GET: Restaurants
        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        // GET: Details
        [HttpGet]
        public ActionResult Details(int? id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        // GET: Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // Process to binding
        [HttpPost]
        [ValidateAntiForgeryToken]      // Attribut
        public ActionResult Create(Restaurant restaurant)
        {
            //if (string.IsNullOrEmpty(restaurant.Name))
            //{
            //    ModelState.AddModelError(nameof(restaurant.Name), "Il n'est pas possible de créer un Restaurant sans nom: The Name is required");
            //} ou

            if (restaurant == null)
            {
                throw new ArgumentNullException(nameof(restaurant));
            }

            if (ModelState.IsValid)
            {
                db.Add(restaurant);
                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            return View();
        }

        // GET: Edit
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var model = db.Get(id);
            if(model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurant restaurant)
        {
            if (restaurant == null)
            {
                throw new ArgumentNullException(nameof(restaurant));
            }

            if (ModelState.IsValid)
            {
                db.Update(restaurant);
                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var model = db.Get(id);
            if(id == null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete (int? id, FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }

}