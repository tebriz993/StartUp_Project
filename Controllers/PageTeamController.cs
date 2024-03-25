using Microsoft.AspNetCore.Mvc;
using StartUpTemp.Data;
using StartUpTemp.Models;

namespace StartUpTemp.Controllers
{
    public class PageTeamController : Controller
    {

        private readonly StartUpTempDbContext _context;
        public PageTeamController(StartUpTempDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<PageTeam> pageTeam = _context.PageTeam.ToList();
            return View(pageTeam);
        }
    }
}
