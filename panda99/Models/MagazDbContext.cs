using Microsoft.EntityFrameworkCore;

namespace panda99.Models
{
    public class MagazDbContext : DbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Deliveri> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
        

        public MagazDbContext(DbContextOptions<MagazDbContext> options)
            : base(options)
        {
        }

        
    }
}
