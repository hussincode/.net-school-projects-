using School_Management.Models;

namespace School_Management.Repo.RepoInterface
{
    public interface IUsers
    {
        public List<User> GetAll();
        public User GetById(int id);
        public void Create(User user);
        public void Update(User user);
        public void Delete(int  id);
    }
}
