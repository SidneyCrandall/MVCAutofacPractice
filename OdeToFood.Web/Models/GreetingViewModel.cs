using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Not just a model. This is an entity
namespace OdeToFood.Web.Models
{
    public class GreetingViewModel
    {
        // Entities of restaurants
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}