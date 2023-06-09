using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Storage.Entity
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string Adress { get; set; }

        [ForeignKey("Authorization")]
        public int Auth_Id { get; set; }
        public Authorization Authorization { get; set; }

        [ForeignKey("Payment")]
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
