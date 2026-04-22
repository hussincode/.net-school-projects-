using System.ComponentModel.DataAnnotations;

namespace Club_Management.Models
{
    public class ActivityModel
    {
        [Key]
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public List<Registration> Registrations { get; set; }
    }
}
