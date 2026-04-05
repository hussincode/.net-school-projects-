using System.ComponentModel.DataAnnotations;

namespace Attendance.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public List<Attendance> Attendances { get; set; }
    }
}
