using Microsoft.EntityFrameworkCore;
using WebApplication9.Models;

namespace WebApplication9.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ShoppingCart> shoppingCarts { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
