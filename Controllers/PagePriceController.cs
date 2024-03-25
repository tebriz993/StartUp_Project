using Microsoft.AspNetCore.Mvc;
using StartUpTemp.Data;
using StartUpTemp.Models;

namespace StartUpTemp.Controllers
{
    public class PagePriceController : Controller
    {
        private readonly StartUpTempDbContext _context;
        public PagePriceController(StartUpTempDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<PagePrice> pagePrice = _context.PagePrice.ToList();
            return View(pagePrice);
        }
    }
}
