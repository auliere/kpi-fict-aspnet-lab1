using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string id)
        {            
            return RedirectToAction("Index", "Contract", new { id = id });
        }
    }
}
