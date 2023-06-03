namespace Project.Storage.Entity
{
    public class SoftToy
    {
        public int SoftToyId { get; set; }
        public string SoftToyName { get; set; }
        public int BasketsId { get; set; }
        public Basket Baskets { get; set; }
    }

    
}
