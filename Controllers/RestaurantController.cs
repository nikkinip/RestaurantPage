using Microsoft.AspNetCore.Mvc;

namespace RestaurantPage.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
