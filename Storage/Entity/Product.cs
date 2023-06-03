using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Storage.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }

        public List<Flower> Flowers { get; set; }
        public List<SoftToy> SoftToys { get; set; }
    }
}
