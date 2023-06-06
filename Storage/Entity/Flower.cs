using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Storage.Entity
{
    public class Flower
    {
        public Guid FlowerId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
