using Microsoft.EntityFrameworkCore;
using System.Data;

namespace canten.Models
{
    public class CanteenContext : DbContext
    {
        public CanteenContext(DbContextOptions<CanteenContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.FoodItem)
                .WithMany(f => f.Orders)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Staff)
                .WithMany(s => s.Orders)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Staff>()
                .HasOne(s => s.User)
                .WithMany(u => u.Staffs)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FoodItem>()
                .HasOne(f => f.User)
                .WithMany(u => u.FoodItems)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
