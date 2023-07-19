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
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
