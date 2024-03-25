using Microsoft.AspNetCore.Mvc;

namespace StartUpTemp.Controllers
{
    public class PageQuoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
