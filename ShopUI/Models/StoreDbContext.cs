using Microsoft.EntityFrameworkCore;

namespace ShopUI.Models
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }    

        public StoreDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Category = "Mobile",
                    Name = "iphone 13",
                    Description = "this is very good phone",
                    Price = 65000000
                },
                new Product
                {
                    Id = 2,
                    Category = "Mobile",
                    Name = "iphone 12",
                    Description = "this is very good phone !!!",
                    Price = 60000000
                },
                new Product
                {
                    Id = 3,
                    Category = "Mobile",
                    Name = "iphone 12 pro",
                    Description = "this is very good phone !!!",
                    Price = 62000000
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
