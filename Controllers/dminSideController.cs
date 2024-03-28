using Microsoft.AspNetCore.Mvc;
using TimeTrove.Data;
using TimeTrove.Models;

namespace TimeTrove.Controllers
{
    public class dminSideController : Controller
    {
        private readonly UserdbContext db;

        public dminSideController(UserdbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details()
        {
            IEnumerable<Register> users = db.Users.ToList();
            return View(users);
        }
    }
}


