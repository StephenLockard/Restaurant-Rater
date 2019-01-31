using RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantRater.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDataBaseContext database = new RestaurantDataBaseContext();

        // GET: Restaurant
        public ActionResult Index()
        {
            return View(database.Restaurants.ToList());
        }
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost][ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                database.Restaurants.Add(restaurant);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restaurant);
            
        }
    }
}