using System.ComponentModel.DataAnnotations;

namespace Project.Storage.Entity
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? PhoneNumber { get; set; }
        public string Email { get; set; }

        public List<Product> Products { get; set; }
    }
}
