namespace RestaurantAndDishes.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Restaurant_Id { get; set; }

        public Dish()
        {
            
        }
    }
}
