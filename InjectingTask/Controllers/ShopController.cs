using Microsoft.AspNetCore.Mvc;

namespace InjectingTask.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Wishlist()
        {
            return View();
        }
        public IActionResult SinglePage()
        {
            return View();
        }
    }
}
