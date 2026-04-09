using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Restaurant_Management_Demo2.Models
{
    public class RestaurantManagementContext : DbContext
    {
        public RestaurantManagementContext(DbContextOptions<RestaurantManagementContext> options) : base(options)
        {

        }

        public DbSet<Order> Order { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
