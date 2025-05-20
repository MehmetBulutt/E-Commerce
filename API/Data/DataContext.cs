using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products =>Set<Product>();

    public DbSet<Cart> Carts => Set<Cart>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
         new List<Product>{
        
          new Product{ Id=1, Name="Iphone 15", Description="Telefon açıklaması", ImageUrl="1.jpg", Price=70000, IsActive=true ,Stock=100},
             new Product{ Id=2, Name="Iphone 16 ", Description="Telefon açıklaması", ImageUrl="16.jpg", Price=80000, IsActive=true ,Stock=100},
              new Product{ Id=3, Name="Iphone 16 Pro", Description="Telefon açıklaması", ImageUrl="16 pro.jpg", Price=90000, IsActive=false ,Stock=100},
               new Product{ Id=4, Name="Iphone 16 Pro Max", Description="Telefon açıklaması", ImageUrl="16 pro max1.jpg", Price=100000, IsActive=true ,Stock=100}
         }
        );
    }
}