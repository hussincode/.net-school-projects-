using canten.Models;
using canten.Repo.RepoInterface;

namespace canten.Repo.RepoClass
{
    public class UserRepo : IUser
    {
        public readonly CanteenContext context;
        public UserRepo(CanteenContext context)
        {
            this.context = context;
        }

        public List<User> GetAllUsers()
        {
            return context.Users.ToList();
        }
        public User GetById(int id)
        {
            return context.Users.Find(id);
        }

        public User CreateUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        public User UpdateUser(User user)
        {
            var data = new User
            {
                UserId = user.UserId,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Phone = user.Phone,
                Role = user.Role
            };
            context.Users.Update(data);
            context.SaveChanges();
            return data;
        }

        public void DeleteUser(int id)
        {
            var data = context.Users.Find(id);
            context.Users.Remove(data);
            context.SaveChanges();
        }


    }
}
