using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public DateOnly date { get; set; }
        public string Status { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

    }
}
