using School_Management.Models;
using School_Management.Repo.RepoInterface;

namespace School_Management.Repo.RepoClass
{
    public class UserRepo : IUsers
    {
        public readonly SchoolContext _context;
        public UserRepo(SchoolContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.UserId == id);
        }

        public void Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges(); 
        }

        public void Update(User user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.UserId == user.UserId);
            if (existingUser != null)
            {
                existingUser.UserId = user.UserId;
                existingUser.Email = user.Email;
                existingUser.Name = user.Name;
                existingUser.Password = user.Password;
                existingUser.PhoneNumber = user.PhoneNumber;

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.UserId == id);
            if (existingUser != null)
            {
                _context.Users.Remove(existingUser);
                _context.SaveChanges();
            }
        }


    }
}
