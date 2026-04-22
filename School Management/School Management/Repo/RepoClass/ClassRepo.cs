using School_Management.Models;
using School_Management.Models.VM;
using School_Management.Repo.RepoInterface;

namespace School_Management.Repo.RepoClass
{
    public class ClassRepo : IClasses
    {
        public readonly SchoolContext _context;
        public ClassRepo(SchoolContext context)
        {
            _context = context;
        }

        public List<Class> GetAll()
        {
            return _context.Classes.ToList();
        }

        public Class GetById(int id)
        {
            return _context.Classes.FirstOrDefault(c => c.ClassId == id);
        }

        public Class GetByName(string name)
        {
            return _context.Classes.FirstOrDefault(c => c.Name == name);
        }

        public void Create(ClassesVM classes)
        {
            var newClass = new Class
            {
                ClassId = classes.ClassId,
                Name = classes.Name,
                TeacherId = classes.TeacherId
            };
            _context.Classes.Add(newClass);
            _context.SaveChanges();
        }
        public void Update(ClassesVM classes)
        {
            var existingClass = _context.Classes.FirstOrDefault(c => c.ClassId == classes.ClassId);
            if (existingClass != null)
            {
                existingClass.ClassId = classes.ClassId;
                existingClass.Name = classes.Name;
                existingClass.TeacherId = classes.TeacherId;
                _context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var existingClass = _context.Classes.FirstOrDefault(c => c.ClassId == id);
            if (existingClass != null)
            {
                _context.Classes.Remove(existingClass);
                _context.SaveChanges();
            }
        }
    }
}
