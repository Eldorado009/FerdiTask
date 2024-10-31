using Microsoft.AspNetCore.Mvc;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
