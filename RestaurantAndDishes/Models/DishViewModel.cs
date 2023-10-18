using RestaurantAndDishes.Data;

namespace RestaurantAndDishes.Models
{
    public class DishViewModel
    {
        public Dish dish_viewModel { get; set; }
        public string RestaurantName { get; set; }

        public DishViewModel()
        {
            
        }

        public DishViewModel(Dish dish, RestaurantAndDishesContext _context)
        {
            dish_viewModel = dish;
            RestaurantName = _context.Restaurant.
                Where(restaurant => restaurant.Id == dish.Restaurant_Id).Select(restaurant => restaurant.Name).FirstOrDefault();
                /*
                                 RestaurantName = _context.Restaurant.Where(restaurant => restaurant.Id == dish.Restaurant_Id)
                .Select(restaurant => restaurant.Name).FirstOrDefault()
            }).ToListAsync();*/
        }
    }
}
