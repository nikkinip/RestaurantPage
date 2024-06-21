using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantPage.Models;

namespace RestaurantPage.Data
{
    public class RestaurantPageContext : DbContext
    {
        public RestaurantPageContext (DbContextOptions<RestaurantPageContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantPage.Models.Dish> Dishes { get; set; } = default!;
    }
}
