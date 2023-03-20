using GameStoreWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWeb.Data {
    public class AppDbContext : DbContext {
        DbSet<User> Users { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderProduct> OrderProducts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }
    }
}
