using Microsoft.AspNetCore.Mvc;
using StartUpTemp.Data;
using StartUpTemp.Models;

namespace StartUpTemp.Controllers
{
    public class PageTestimonialController : Controller
    {
        private readonly StartUpTempDbContext _context;
        public PageTestimonialController(StartUpTempDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<PageTestimonial> pageTestimonial = _context.PageTestimonial.ToList();
            return View(pageTestimonial);
        }
    }
}
