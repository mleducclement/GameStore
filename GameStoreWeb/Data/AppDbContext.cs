using GameStoreWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWeb.Data {
    public class AppDbContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }
    }
}
