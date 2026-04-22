using canten.Models;

namespace canten.Repo.RepoInterface
{
    public interface IStaff
    {
        public List<Staff> GetAllStaffs();
        public Staff GetById(int id);
        public Staff CreateStaff(Staff staff);
        public Staff UpdateStaff(Staff staff);
        public void DeleteStaff(int id);
    }
}
