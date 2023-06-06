using Microsoft.AspNetCore.Mvc;
using Project.Models.Interface;
using Project.Storage.Entity;

namespace Project.Controllers
{
    public class FlowerController : Controller
    {
        private readonly IFlowers _manager;

        public FlowerController(IFlowers manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> Index()
        {
            var flowerData = await _manager.GetAllFlower();
            return View(flowerData);
        }

        [HttpGet]
        [Route("flowerData")]
        public async Task<IActionResult> GetAll()
        {
            var flowerData = await _manager.GetAllFlower();
            return Ok(flowerData);
        }

        [HttpPut]
        public async Task<IActionResult> Create([FromBody] Flower flower)
        {
            await _manager.AddFlower(flower);
            return Ok();
        }
    }
}
