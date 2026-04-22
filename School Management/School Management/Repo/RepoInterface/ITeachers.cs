using School_Management.Models;
using School_Management.Models.VM;

namespace School_Management.Repo.RepoInterface
{
    public interface ITeachers
    {
        public List<Teacher> GetAll();
        public Teacher GetById(int id);
        public void Create(TeachersVM teacher);
        public void Update(TeachersVM teacher);
        public void Delete(int id);
    }
}
