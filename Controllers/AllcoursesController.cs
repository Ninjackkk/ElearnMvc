using Microsoft.AspNetCore.Mvc;
using onl.Data;
using onl.Models; 

namespace onl.Controllers
{
    public class AllcoursesController : Controller
    {
        private readonly ApplicationDbContext db;

        public AllcoursesController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var data = db.Courses.ToList();
            return View(data);
        }

    }
}
