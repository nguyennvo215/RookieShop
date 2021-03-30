using Microsoft.EntityFrameworkCore;
using RookieShop.BackEnd.Data.Configurations;
using RookieShop.BackEnd.Data.Entities;

namespace RookieShop.BackEnd.Data
{
    public class RookieShopDbContext : DbContext
    {
        public RookieShopDbContext(DbContextOptions<RookieShopDbContext> options)
            : base(options) { }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RetailDetail> RetailDetails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new RetailDetailConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserInRoleConfiguration());
            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();
            base.OnModelCreating(modelBuilder);
        }
    }
}
