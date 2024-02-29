using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TimeTrove.Models;

namespace TimeTrove.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Mens()
        {
            return View();
        }
        public IActionResult Womens()
        {
            return View();
        }
        public IActionResult Kids() {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
   

    }


}
