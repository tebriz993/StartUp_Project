using Microsoft.AspNetCore.Mvc;
using StartUpTemp.Data;
using StartUpTemp.Models;

namespace StartUpTemp.Controllers
{
    public class ServicesController : Controller
    {
        private readonly StartUpTempDbContext _context;
        public ServicesController(StartUpTempDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Services> services = _context.Services.ToList();
            return View(services);
        }
    }
}
