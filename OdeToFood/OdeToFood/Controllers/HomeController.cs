using System;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {

        IRestaurantService _restaurantService;

        public HomeController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        public IActionResult Index()
        {
            return View(_restaurantService.GetAll());
        }
    }
}
