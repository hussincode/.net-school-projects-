using School_Management.Models;
using School_Management.Models.VM;
using School_Management.Repo.RepoInterface;

namespace School_Management.Repo.RepoClass
{
    public class StudentRepo : IStudents
    {
        public readonly SchoolContext _context;
        public StudentRepo(SchoolContext context)
        {
            _context = context;
        }
        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }
        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.StudentId == id);
        }
        public void Create(StudentsVM student)
        {
            var newStudent = new Student
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Email = student.Email,
                UserId = student.UserId,
                DateOfBirth = student.DateOfBirth,
                Phone = student.Phone
            };
        }

        public void Update(StudentsVM student)
        {
            var existingStudent = _context.Students.FirstOrDefault(s => s.StudentId == student.StudentId);
            if (existingStudent != null)
            {
                existingStudent.StudentId = student.StudentId;
                existingStudent.Name = student.Name;
                existingStudent.Email = student.Email;
                existingStudent.UserId = student.UserId;
                existingStudent.DateOfBirth = student.DateOfBirth;
                existingStudent.Phone = student.Phone;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var existingStudent = _context.Students.FirstOrDefault(s => s.StudentId == id);
            if (existingStudent != null)
            {
                _context.Students.Remove(existingStudent);
                _context.SaveChanges();
            }
        }
    }
}
