using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TimeTrove.Data;
using TimeTrove.Models;

namespace TimeTrove.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserdbContext db;

        public HomeController(UserdbContext db, ILogger<HomeController> logger)
        {
            this.db = db;
            _logger = logger;
        }




        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Signup(Register register)
        {
            if (db.Users.Any(x => x.Name == register.Name))
            {
                ViewBag.Notification = "This account has already existed";
                return View();
            }
            else
            {
                db.Users.Add(register);
                db.SaveChanges();
                
                return RedirectToAction("Login", "Home");
            }

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Register register, Nadmin admin)
        {

            var adminLogin = db.Admin.Where(x => x.Email == admin.Email && x.Pass == admin.Pass).Select(x => new { x.Id, x.Name,x.profile }).FirstOrDefault();
            if (adminLogin != null)
            {
                
                HttpContext.Session.SetString("ID", adminLogin.Id.ToString());
                HttpContext.Session.SetString("Name", adminLogin.Name.ToString());
                HttpContext.Session.SetString("profile", adminLogin.profile);
                TempData["Message"] = "Welcome, " + adminLogin.Name.ToString();

                return RedirectToAction("Index", "Admin");

            }

            else
            {
                var checkLogin = db.Users.Where(x => x.Email.Equals(register.Email) && x.Pass.Equals(register.Pass)).Select(x => new { x.Id, x.Name }).FirstOrDefault();
                if (checkLogin != null)
                {

                    HttpContext.Session.SetString("Id", checkLogin.Id.ToString());
                    HttpContext.Session.SetString("Name", checkLogin.Name.ToString());

                    TempData["Message"] = "Welcome," + checkLogin.Name.ToString();

                    return RedirectToAction("Index", "Home");
                }
                else
                {

                    ViewBag.Notification = "Enter Wrong Email or Password";
                }
            }

            return View();

        }





        public IActionResult Logout() { 
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");

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
       
        public IActionResult About() 
        {
            return View();
        }
        public IActionResult Company()
        {
            return View();
        }
        public IActionResult Offices() 
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }

   

    }


}
