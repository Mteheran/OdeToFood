using System;
using System.Collections.Generic;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantService : IRestaurantService
    {

        List<Restaurant> restaurants;

        public InMemoryRestaurantService()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant() { Id= 1, Name="Migue Pizza"},
                new Restaurant() { Id=2, Name="Niku"},
                new Restaurant() { Id=3, Name="Al lado del camino"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return (System.Collections.Generic.IEnumerable<OdeToFood.Models.Restaurant>)restaurants;
        }
    }
}
















