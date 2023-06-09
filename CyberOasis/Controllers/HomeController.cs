﻿using CyberOasis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CyberOasis.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index() => View();
        public IActionResult NotFound404() => View();


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}