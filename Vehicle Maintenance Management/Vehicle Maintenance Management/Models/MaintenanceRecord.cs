using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Maintenance_Management.Models
{
    public class MaintenanceRecord
    {
        [Key]
        public int MaintenanceRecordId { get; set; }
        public DateTime ServiceDate { get; set; }
        public int CurrentKm { get; set; }
        public string Notes { get; set; }
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        [ForeignKey("MaintenanceType")]
        public int MaintenanceTypeId { get; set; }
        public MaintenanceType MaintenanceType { get; set; }
    }
}
