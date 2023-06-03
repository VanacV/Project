namespace Project.Storage.Entity
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string login { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public Basket Basket { get; set; }
        public Shop Shop { get; set; }  
        public int BasketId { get; set; }
    }
}
