namespace Vehicle_Maintenance_Management.Models.Repo.RepoInterface
{
    public interface IMaintenanceType
    {
        public List<MaintenanceType> GetAll();
        public MaintenanceType GetById(int id);
       public void Add(MaintenanceType type);
       public void Update(MaintenanceType type);
       public void Delete(int id);
    }

}
