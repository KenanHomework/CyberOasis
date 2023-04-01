using Microsoft.AspNetCore.Mvc;

namespace CyberOasis.Controllers;

public class EntryController : Controller
{
    public IActionResult Index()
    {
        return View();
    } 
    
    public IActionResult Editor()
    {
        return View();
    }
}
