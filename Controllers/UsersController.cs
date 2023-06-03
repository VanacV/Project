using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
