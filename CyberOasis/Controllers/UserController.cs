using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CyberOasis.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public IActionResult Profile() => View();
        public IActionResult Favorities() => View();
        public IActionResult Settings() => View();
    }
}
