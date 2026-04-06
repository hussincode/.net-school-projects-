namespace Attendance.Models
{
    public class StudentRepo : Istudent
    {
        public readonly List<Student> _students;
        public StudentRepo()
        {
            _students = new List<Student>();
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public void ADD(Student student)
        {
            _students.Add(student);
        }

        public void DELETE(Student student)
        {
            _students.Remove(student);
        }

        public void Update(Student student)
        {
            var existing = _students.FirstOrDefault(s => s.StudentId == student.StudentId);
            if (existing != null)
            {
                existing.Name = student.Name;
               existing.Email = student.Email;


            }
        }

        public Student GetById(int id)
        {
            return _students.FirstOrDefault(s => s.StudentId == id);
        }
    }
}
