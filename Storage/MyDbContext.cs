using Microsoft.EntityFrameworkCore;
using Project.Storage.Entity;

namespace Project.Storage
{
    public class MyDbContext:DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Items { get; set; }  
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<SoftToy> SoftToys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ExampleDb;Trusted_Connection=True;");
        }

    }

}
