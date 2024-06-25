using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantPage.Data;
using RestaurantPage.Models;
using System.Diagnostics;

namespace RestaurantPage.Controllers
{
    public class HomeController : Controller
    {
      //  private readonly ILogger<HomeController> _logger;

    /*    public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();

        }
        private readonly RestaurantPageContext _context;
        public HomeController(RestaurantPageContext context)
            {
                _context = context;
            }

          
        public  async Task<IActionResult>  Gallery()
        {
                if (_context.Dishes == null)
                {
                    return Problem("Entity set 'RestaurantPageContext.cs'  is null.");
                }

                var Dishes = from m in _context.Dishes
                             select m;


                return View(await Dishes.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
