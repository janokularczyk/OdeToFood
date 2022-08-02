using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>() 
            {
                new Restaurant { Id = 1, Name = "Pizza Planet", Location = "New York City", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Ramen Shop", Location = "Tokyo", Cuisine = CuisineType.Japanese},
                new Restaurant { Id = 3, Name = "Spicy Tacos", Location = "Mexico City", Cuisine = CuisineType.Mexican}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
