using System.Collections.Specialized;

namespace Attendance.Models
{
    public class VM
    {
        public int Id { get; set; }
        public Student Students { get; set; }
        public List<Student> StudentList { get; set; }
        public Subject Subjects { get; set; }
        public List<Subject> SubjectList { get; set; }
        public int StudentId { get; set; }
            public int SubjectId { get; set; }  
        public string Status { get; set; }
        public DateOnly date { get; set; }

    }
}
