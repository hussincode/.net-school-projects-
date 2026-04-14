using Hotel_Management_System.Models;
using Hotel_Management_System.Repo.RepoInterface;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Hotel_Management_System.Repo.RepoClass
{
    public class UserRepo : IUsers
    {
        public readonly HotelContext _context;
        public UserRepo(HotelContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            var data = _context.users.ToList();
            return data;
        }

        public User GetById(int id)
        {
            var data = _context.users.Find(id);
            return data;
        }

        public void Add(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();

        }

        public void Update(User record)
        {
            _context.users.Update(record);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _context.users.FirstOrDefault(u => u.UserId == id);
            _context.users.Remove(data);
            _context.SaveChanges();
        }
    }
}
