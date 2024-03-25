using Microsoft.AspNetCore.Mvc;
using StartUpTemp.Data;
using StartUpTemp.Models;

namespace StartUpTemp.Controllers
{
    public class AboutController : Controller
    {

        private readonly StartUpTempDbContext _context;
        public AboutController(StartUpTempDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            About? about = _context.About.FirstOrDefault();
            return View(about);
        }
    }
}
