using canten.Models;

namespace canten.Repo.RepoInterface
{
    public interface IUser
    {
        public List<User> GetAllUsers();
        public User GetById(int id);
        public User CreateUser(User user);
        public User UpdateUser(User user);
        public void DeleteUser(int id);
    }
}
