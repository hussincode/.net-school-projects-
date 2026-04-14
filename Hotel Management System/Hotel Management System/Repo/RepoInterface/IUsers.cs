using Hotel_Management_System.Models;
using Hotel_Management_System.Models.VM;

namespace Hotel_Management_System.Repo.RepoInterface
{
    public interface IUsers
    {
        public List<User> GetAll();
        public User GetById(int id);
        public void Add(User record);
        public void Update(User record);
        public void Delete(int id);
    }
}
