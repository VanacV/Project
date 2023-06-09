using Microsoft.EntityFrameworkCore;
using Project.Models.Interface;
using Project.Storage.Entity;

namespace Project.Storage
{
    public class MyDbContext:DbContext
    {
        public DbSet<Authorization> Authorization { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Product_Rating> Product_Rating { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Shop_Rating> Shop_Rating { get; set; }
        public DbSet<Composition> Composition { get; set; }
        public DbSet<Payment> Payment { get; set; } 
        public DbSet<Malling> Malling { get; set; }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ExampleDb;Trusted_Connection=True;");
        }

    }

}
