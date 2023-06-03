using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class FlowerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
