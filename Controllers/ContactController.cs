using Microsoft.AspNetCore.Mvc;

namespace StartUpTemp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
