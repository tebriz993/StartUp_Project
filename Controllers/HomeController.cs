using Microsoft.AspNetCore.Mvc;
using StartUpTemp.Data;
using StartUpTemp.Models;

namespace StartUpTemp.Controllers
{
    public class HomeController : Controller
    {

        private readonly StartUpTempDbContext _context;
        public HomeController(StartUpTempDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Home> home = _context.Home.ToList();
            return View(home);
        }
    }
}
