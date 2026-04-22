using School_Management.Models;
using School_Management.Models.VM;

namespace School_Management.Repo.RepoInterface
{
    public interface IStudents
    {
        public List<Student> GetAll();
        public Student GetById(int id);
        public void Create(StudentsVM student);
        public void Update(StudentsVM student);
        public void Delete(int id);
    }
}
