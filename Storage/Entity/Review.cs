using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Storage.Entity
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Comments { get; set; }
        public string Rating { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
