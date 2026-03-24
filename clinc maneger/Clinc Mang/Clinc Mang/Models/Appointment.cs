using System.ComponentModel.DataAnnotations.Schema;

namespace Clinc_Mang.Models
{
    public class Appointment
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        [ForeignKey("DoctorsId")]
        public int DoctorsId { get; set; }
        public Doctor Doctors { get; set; }
        [ForeignKey("PatientsId")]
        public int PatientsId { get; set; }
        public Patient Patients { get; set; }
    }
}
