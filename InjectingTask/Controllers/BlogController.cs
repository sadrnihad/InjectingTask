using Microsoft.AspNetCore.Mvc;

namespace InjectingTask.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult blog()
        {
            return View();
        }
    }
}
