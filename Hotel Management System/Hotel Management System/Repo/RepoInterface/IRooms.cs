using Hotel_Management_System.Models;
using Hotel_Management_System.Models.VM;

namespace Hotel_Management_System.Repo.RepoInterface
{
    public interface IRooms
    {
        public List<Room> GetAll();
        public Room GetById(int id);
        public void Add(RoomVM record);
        public void Update(RoomVM record);
        public void Delete(int id);
    }
}
