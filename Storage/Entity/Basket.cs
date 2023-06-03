namespace Project.Storage.Entity
{
    public class Basket
    {
        public int BasketId { get; set; }
        public int TotalPrice { get; set; }

        public int UserId { get; set; }
        public Users Users { get; set; }
        public Product Products { get; set; }
        public ICollection <SoftToy> SoftToys { get; set; }

        public ICollection <Flower> Flowers { get; set; }
    }
}
