using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace RestaurantPage.Models;


public class Dish
    { 
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? DishType { get; set; }
        public string? Origin { get; set; }
        public decimal Price { get; set; }
    }

    