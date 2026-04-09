using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Maintenance_Management.Models
{
    public class MaintenanceRecordViewModel
    {
        [ForeignKey("maintenanceTypes")]
        public int MaintenanceTypeId { get; set; }
        public List<MaintenanceType> maintenanceTypes { get; set; }
        [ForeignKey("vehicles")]
        public int VehicleId { get; set; }
        public List<Vehicle> vehicles { get; set; }
        public int MaintenanceRecordId { get; set; }
        public DateTime ServiceDate { get; set; }
        public string VehiclePlate { get; set; }
        public string MaintenanceTypeName { get; set; }
        public int CurrentKm { get; set; }
        public string Notes { get; set; }
    }
}
