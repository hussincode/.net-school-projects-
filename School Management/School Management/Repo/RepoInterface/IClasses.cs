using School_Management.Models;
using School_Management.Models.VM;

namespace School_Management.Repo.RepoInterface
{
    public interface IClasses
    {
        public List<Class> GetAll();
        public Class GetById(int id);
        public void Create(ClassesVM classes);
        public void Update(ClassesVM classes);
        public void Delete(int id);
    }
}
