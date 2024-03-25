using Microsoft.AspNetCore.Mvc;
using StartUpTemp.Data;
using StartUpTemp.Models;

namespace StartUpTemp.Controllers
{
    public class PageFeatureController : Controller
    {
        private readonly StartUpTempDbContext _context;
        public PageFeatureController(StartUpTempDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<PageFeature> pageFeature = _context.PageFeature.ToList();
            return View(pageFeature);
        }
    }
}
