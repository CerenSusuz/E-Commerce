using System.Reflection;
using DataAccess.Entities;
using DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts.EF
{
    public class ECommerceContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountAddress> AccountAddresses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<ExchangeRateHistory> ExchangeRateHistories { get; set; }
        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<RelatedProduct> RelatedProducts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }

        public ECommerceContext()
        {
            
        }

        public ECommerceContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ECommerce;User=sa;Password=Yaren#1998;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SetDataType();
            base.OnModelCreating(modelBuilder);
        }
    }
}