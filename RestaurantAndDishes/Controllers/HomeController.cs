using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantAndDishes.Data;
using RestaurantAndDishes.Models;
using System.Diagnostics;

namespace RestaurantAndDishes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RestaurantAndDishesContext _context; // Connection to the database (to use for randomizing dish)

        public HomeController(ILogger<HomeController> logger, RestaurantAndDishesContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetRandomDish()
        {
            Random rand = new Random();
            int skipElements = rand.Next(0, _context.Dishes.Count());

            var randomDish = _context.Dishes.Skip(skipElements).Take(1).FirstOrDefault(); //Taking the first existing dish after skipped number of elements
            DishViewModel dishForView = new DishViewModel(randomDish, _context);

            if (randomDish != null)
            {
                var data = new
                {
                    dishName = dishForView.dish_viewModel.Name,
                    restaurantName = dishForView.RestaurantName
                };

                return Json(data);
            }

            return Json(null);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}