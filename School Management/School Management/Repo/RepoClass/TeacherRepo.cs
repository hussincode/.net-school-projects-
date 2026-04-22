using School_Management.Models;
using School_Management.Models.VM;
using School_Management.Repo.RepoInterface;

namespace School_Management.Repo.RepoClass
{
    public class TeacherRepo : ITeachers
    {
        public readonly SchoolContext _context;
        public TeacherRepo(SchoolContext context)
        {
            _context = context;
        }

        public List<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetById(int id)
        {
            return _context.Teachers.FirstOrDefault(t => t.TeacherId == id);
        }

        public void Create(TeachersVM teacher)
        {
            var newTeacher = new Teacher
            {
                TeacherId = teacher.TeacherId,
                Name = teacher.Name,
                Specialization = teacher.Specialization,
                UserId = teacher.UserId,
                PhoneNumber = teacher.PhoneNumber,
                HireDate = teacher.HireDate,


            };
            _context.Teachers.Add(newTeacher);
            _context.SaveChanges();
        }

        public void Update(TeachersVM teacher)
        {
            var existingTeacher = _context.Teachers.FirstOrDefault(t => t.TeacherId == teacher.TeacherId);
            if (existingTeacher != null)
            {
                existingTeacher.TeacherId = teacher.TeacherId;
                existingTeacher.Name = teacher.Name;
                existingTeacher.Specialization = teacher.Specialization;
                existingTeacher.UserId = teacher.UserId;
                existingTeacher.PhoneNumber = teacher.PhoneNumber;
                existingTeacher.HireDate = teacher.HireDate;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var existingTeacher = _context.Teachers.FirstOrDefault(t => t.TeacherId == id);
            if (existingTeacher != null)
            {
                _context.Teachers.Remove(existingTeacher);
                _context.SaveChanges();
            }
        }
    }
}
