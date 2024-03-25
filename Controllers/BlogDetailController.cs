using Microsoft.AspNetCore.Mvc;
using StartUpTemp.Data;
using StartUpTemp.Models;

namespace StartUpTemp.Controllers
{
    public class BlogDetailController : Controller
    {

        private readonly StartUpTempDbContext _context;
        public BlogDetailController(StartUpTempDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            BlogDetail? blogDetail = _context.BlogDetail.FirstOrDefault();
            return View(blogDetail);
        }
    }
}
