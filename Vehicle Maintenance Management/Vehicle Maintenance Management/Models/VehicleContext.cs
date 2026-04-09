using Microsoft.EntityFrameworkCore;

namespace Vehicle_Maintenance_Management.Models
{
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<MaintenanceType> MaintenanceTypes { get; set; }
        public DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }
    
    }
}
