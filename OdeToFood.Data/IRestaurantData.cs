﻿using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;

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
                new Restaurant { Id = 1, Name = "Lee's Pizza", Location = "Stuttgart", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Lee's Borito", Location = "Stuttgart", Cuisine = CuisineType.Mexican},
                new Restaurant { Id = 3, Name = "Lee's Chutney", Location = "Stuttgart", Cuisine = CuisineType.Indian },
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
