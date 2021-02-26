using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Product>()
                .Property(e => e.Price)
            // .HasConversion<decimal>();
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .HasConversion(
                    v => (double)v,
                    v => (decimal)v);
        }
    }
}