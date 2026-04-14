using Hotel_Management_System.Models;
using Hotel_Management_System.Models.VM;

namespace Hotel_Management_System.Repo.RepoInterface
{
    public interface IServiceTypes
    {
        public List<ServiceType> GetAll();
        public ServiceType GetById(int id);
        public void Add(ServiceTypesVM record);
        public void Update(ServiceTypesVM record);
        public void Delete(int id);
    }
}
