using Microsoft.AspNetCore.Mvc;

namespace MVCProniaApp.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SinglePageDetail()
        {
            return View();
        }
        public IActionResult Wishlist()
        {
            return View();
        }
    }
}