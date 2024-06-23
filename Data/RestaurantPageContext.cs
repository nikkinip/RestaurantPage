using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantPage.Models;


namespace RestaurantPage.Data
{
    public class RestaurantPageContext : IdentityDbContext<PageUser>
    {
        public RestaurantPageContext (DbContextOptions<RestaurantPageContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantPage.Models.Dish> Dishes { get; set; } = default!;
    }
}
