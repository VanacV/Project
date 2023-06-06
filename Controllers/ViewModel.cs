using Project.Storage.Entity;

namespace Project.Controllers
{
    internal class ViewModel
    {
        public List<Shop> Shop { get; set; }
        public List<Product> Items { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Users> Users { get; set; }
        public List<Flower> IFlowers { get; set; }
        public List<SoftToy> SoftToy { get; set; }
    }
}