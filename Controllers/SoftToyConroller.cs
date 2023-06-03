using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class SoftToyConroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
