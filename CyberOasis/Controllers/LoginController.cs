using CyberOasis.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Security.Claims;

namespace CyberOasis.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult AdminLogin() => View();

        public IActionResult Index(string mode)
        {

            ClaimsPrincipal user = HttpContext.User;


            ViewBag.Title = "Sign In";
            ViewBag.Mode = "";
            if (!string.IsNullOrWhiteSpace(mode) && mode.ToLower() == "sign-up")
            {
                ViewBag.Mode = "sign-up-mode";
                ViewBag.Title = "Sign Up";
            }
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(LoginVM loginVM)
        //{
        //    Console.WriteLine(loginVM);


        //    return View();
        //}

        [HttpPost]
        public IActionResult SignIn(LoginVM loginVM)
        {

            Console.WriteLine("SignIn");

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SignUp(LoginVM loginVM)
        {

            Console.WriteLine("SignUp");

            return RedirectToAction("Index");
        }

    }
}
