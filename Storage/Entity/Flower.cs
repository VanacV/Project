namespace Project.Storage.Entity
{
    public class Flower
    {
        public int FlowerId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }   
        public int BasketsId { get; set; }
        public Basket Baskets { get; set; }
    }
}
