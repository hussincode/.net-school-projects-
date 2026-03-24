using System.ComponentModel.DataAnnotations.Schema;

namespace Clinc_Mang.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [ForeignKey("AppointmentId")]
        public int AppointmentId { get; set; }
        public List<Appointment> Appointment { get; set; }
    }
}
