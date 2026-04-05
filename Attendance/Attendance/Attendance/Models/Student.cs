using System.ComponentModel.DataAnnotations;

namespace Attendance.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Attendance> Attendances { get; set; }

    }
}
