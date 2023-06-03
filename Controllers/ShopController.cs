using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
