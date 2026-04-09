using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Maintenance_Management.Models
{
    public class VehicleViewModel
    {
        [ForeignKey("MaintenanceRecord")]
        public int UserId { get; set; }
        public List<User> Users { get; set; }
        public int VehicleId { get; set; }
            public string PlateNumber { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string OwnerName { get; set; }
        

    }
}
