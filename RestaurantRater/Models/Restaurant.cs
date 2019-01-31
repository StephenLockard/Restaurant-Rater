using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Rating { get; set; }

    }
        public class RestaurantDataBaseContext : DbContext
        {
            public DbSet<Restaurant> Restaurants { get; set; }
        }
}