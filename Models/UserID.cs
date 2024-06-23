
using Microsoft.AspNetCore.Identity;
namespace RestaurantPage.Models
{
    public class PageUser : IdentityUser
    {
        public PageUser(string userName) : base(userName) { }
        public PageUser() { }
    }
}