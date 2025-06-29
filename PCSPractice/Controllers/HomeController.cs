using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCSPractice.Models;
using System;
using System.Diagnostics;
using PCSPractice.Data;

namespace PCSPractice.Controllers
{ 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PcsDbContext _context;

        public HomeController(ILogger<HomeController> logger, PcsDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
