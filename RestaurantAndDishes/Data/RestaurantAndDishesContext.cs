using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantAndDishes.Models;

namespace RestaurantAndDishes.Data
{
    public class RestaurantAndDishesContext : DbContext
    {
        public RestaurantAndDishesContext (DbContextOptions<RestaurantAndDishesContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantAndDishes.Models.Restaurant> Restaurant { get; set; }
        public DbSet<RestaurantAndDishes.Models.Dish> Dishes { get; set; }
    }
}
