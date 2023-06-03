using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
