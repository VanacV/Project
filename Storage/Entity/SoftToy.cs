using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Storage.Entity
{
    public class SoftToy
    {
        public int SoftToyId { get; set; }
        public string SoftToyName { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }


}
