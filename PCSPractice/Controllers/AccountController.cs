using Microsoft.AspNetCore.Mvc;

namespace PCSPractice.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
