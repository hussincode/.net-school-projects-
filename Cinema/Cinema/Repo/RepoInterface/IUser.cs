using Cinema.Models;

namespace Cinema.Repo.RepoInterface
{
    public interface IUser
    {
        List<User> GetAllAsync();
        User GetByIdAsync(int id);
        public void AddAsync(User user);
        public void UpdateAsync(User user);
        public void DeleteAsync(int id);


        User GetByPhoneAsync(string phone);
    }
}
