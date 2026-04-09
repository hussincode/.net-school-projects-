using System.ComponentModel.DataAnnotations;

namespace Vehicle_Maintenance_Management.Models
{
    public class MaintenanceType
    {
        [Key]
        public int MaintenanceTypeId { get; set; }
        public string Name { get; set; }
        public string RecommendedKm { get; set; }
        public List<MaintenanceRecord> MaintenanceRecords { get; set; }

    }
}
