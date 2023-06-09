using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project.Storage.Entity
{
    public class Shop_Rating
    {
        [Key]
        public int Shop_Rat_Id { get; set; }
        public float Rate { get; set; }
        public string Comment { get; set; }

        [ForeignKey("Shop")]
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
