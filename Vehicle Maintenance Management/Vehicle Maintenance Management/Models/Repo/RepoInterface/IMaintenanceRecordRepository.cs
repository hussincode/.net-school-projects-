namespace Vehicle_Maintenance_Management.Models.Repo.RepoInterface
{
    public interface IMaintenanceRecordRepository
    {
        public List<MaintenanceRecordViewModel> GetAll();
        MaintenanceRecordViewModel GetById(int id);
        void Add(MaintenanceRecord record);
        void Update(MaintenanceRecord record);
        void Delete(int id);
    }
}
