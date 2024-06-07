using System.ComponentModel.DataAnnotations;

namespace RestaurantPage.Models
{
    public class Restaurant
    { 
        public int Id { get; set; }
        public string? Dish { get; set; }
        public string? ImageUrl { get; set; }

        public string? Origin { get; set; }
        public decimal Price { get; set; }
    }
}
    