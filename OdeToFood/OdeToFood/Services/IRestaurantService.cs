using System;
using System.Collections.Generic;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public interface IRestaurantService
    {
        IEnumerable<Restaurant> GetAll();
    }
}
