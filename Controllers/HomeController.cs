
using FinalWebDevProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalWebDevProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Food()
        {
            return View();
        }

        public IActionResult Game()
        {
            return View();
        }
        public IActionResult Movie()
        {
            return View();
        }
        public IActionResult Sports()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }




    }
}