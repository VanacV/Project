using System.Diagnostics;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Models.Interface;
using Project.Storage;
using Project.Storage.Entity;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        public IActionResult Index()
        {
            var db = new MyDbContext();
            var shop = db.Shops.ToList();
            var product = db.Items.ToList();
            var review = db.Reviews.ToList();
            var users = db.Users.ToList();
            var flower = db.Flowers.ToList();
            var softToy = db.SoftToys.ToList();
            var model = new ViewModel {Shop = shop, Items = product, Reviews = review,Users = users,IFlowers =flower, SoftToy= softToy};
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}