using Microsoft.AspNetCore.Mvc;
using StartUpTemp.Data;
using StartUpTemp.Models;

namespace StartUpTemp.Controllers
{
    public class BlogGridController : Controller
    {

        private readonly StartUpTempDbContext _context;
        public BlogGridController(StartUpTempDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<BlogGrid> blogGrid = _context.BlogGrid.ToList();
            return View(blogGrid);
        }
    }
}
