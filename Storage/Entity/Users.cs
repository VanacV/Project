using System.ComponentModel.DataAnnotations;

namespace Project.Storage.Entity
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string login { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
