using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Maintenance_Management.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public string PlatNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        [ForeignKey("Owner")]
        public int OwnerId { get; set; }

        public User Owner { get; set; }
        public List<MaintenanceRecord> MaintenanceRecords { get; set; }
    }
}
