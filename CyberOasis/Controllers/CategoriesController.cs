using Microsoft.AspNetCore.Mvc;

namespace CyberOasis.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult View(string id)
        {
            return View();
        }
    }
}
