namespace Project.Storage.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

        public int ShopId { get; set; }
        public int BasketsId { get; set; }

        public Shop Shop { get; set; }
        public Basket Baskets { get; set; }
    }
}
