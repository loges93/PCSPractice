using Microsoft.AspNetCore.Mvc;
using PCSPractice.Data;

namespace PCSPractice.Controllers
{
    public class AccountController : Controller
    {
        private readonly PcsDbContext _context;

        public AccountController(PcsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string username, string password)
        {
            ViewBag.username = username;
            ViewBag.password = password;
            return View();
        }
    }
}
