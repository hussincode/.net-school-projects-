using Hotel_Management_System.Models;
using Hotel_Management_System.Models.VM;
using Hotel_Management_System.Repo.RepoInterface;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Management_System.Repo.RepoClass
{
    public class ServiceTypesRepo : IServiceTypes
    {
        public readonly HotelContext _context;
        public ServiceTypesRepo(HotelContext context)
        {
            _context = context;
        }

        public List<ServiceType> GetAll()
        {
            return _context.serviceTypes.Include(g => g.User).ToList();
        }

        public ServiceType GetById(int id)
        {
            var data = _context.serviceTypes.Find(id);
            return data;
        }

        public void Add(ServiceTypesVM user)
        {
            var data = new ServiceType
            {
                ServiceTypeId = user.ServiceTypeId,
                Name = user.Name,
                    Price = user.Price,
                    UserId = user.UserId,

            };
            _context.serviceTypes.Add(data);
            _context.SaveChanges();
        }

        public void Update(ServiceTypesVM user)
        {
            var data = new ServiceType
            {
                ServiceTypeId = user.ServiceTypeId,
                Name = user.Name,
                Price = user.Price,
                UserId = user.UserId,
            };
            _context.serviceTypes.Update(data);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _context.serviceTypes.FirstOrDefault(r => r.ServiceTypeId == id);
            if (data != null)
            {
                _context.serviceTypes.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
