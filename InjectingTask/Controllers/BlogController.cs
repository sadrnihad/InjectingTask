using Microsoft.AspNetCore.Mvc;

namespace MVCProniaApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}