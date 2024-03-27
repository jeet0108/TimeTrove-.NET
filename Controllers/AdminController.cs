using Microsoft.AspNetCore.Mvc;
using TimeTrove.Data;
using TimeTrove.Models;

namespace TimeTrove.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserdbContext db;

        public AdminController(UserdbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            Nadmin de = new();
            return View(de);
        }
        public IActionResult Details()
        {
            IEnumerable<Register> admin = db.Users;
            return View(admin);
        }
    }
}
