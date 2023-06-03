namespace Project.Storage.Entity
{
    public class Shop
    {
        public int Id{ set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public int? PhoneNumber { set; get; }
        public string? Email { set; get; }

        public ICollection<Product> Products { set; get; }
    }
}
