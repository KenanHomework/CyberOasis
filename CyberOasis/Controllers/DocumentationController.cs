using Microsoft.AspNetCore.Mvc;

namespace CyberOasis.Controllers
{
    public class DocumentationController : Controller
    {
        public IActionResult UserAgreement() => View();
        public IActionResult TermsConditions() => View();
        public IActionResult PrivacyPolicy() => View();
    }
}
