using Hotel_Management_System.Models;
using Hotel_Management_System.Models.VM;
using Hotel_Management_System.Repo.RepoInterface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace Hotel_Management_System.Repo.RepoClass
{
    public class RoomRepo : IRooms
    {
        public readonly HotelContext _context;
        public RoomRepo(HotelContext context)
        {
            _context = context;
        }

        public List<Room> GetAll()
        {
           return _context.rooms.Include(g => g.User).ToList();
        }

        public Room GetById(int id)
        {
            var data = _context.rooms.Find(id);
            return data;
        }

        public void Add(RoomVM user)
        {
            var data = new Room
            {
                RoomId = user.RoomId,
                RoomNumber = user.RoomNumber,
                Type = user.Type,
                PricePerNight = user.PricePerNight,
                Status = user.Status,
                UserId = user.UserId,
            };
            _context.rooms.Add(data);
            _context.SaveChanges();
        }

        public void Update(RoomVM record)
        {
            var data = new Room
            {
                RoomId = record.RoomId,
                RoomNumber = record.RoomNumber,
                Type = record.Type,
                PricePerNight = record.PricePerNight,
                Status = record.Status,
                UserId = record.UserId,
            };
            _context.rooms.Update(data);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _context.rooms.FirstOrDefault(r => r.RoomId == id);
            if (data != null)
            {
                _context.rooms.Remove(data);
                _context.SaveChanges();
            }
        }

    }
}
