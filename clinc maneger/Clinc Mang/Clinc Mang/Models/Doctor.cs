using System.ComponentModel.DataAnnotations.Schema;

namespace Clinc_Mang.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        [ForeignKey("AppointmentId")]
        public int AppointmentId { get; set; }
        public List<Appointment> Appointment { get; set; }
    }
}
