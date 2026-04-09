namespace Vehicle_Maintenance_Management.Models.Repo.RepoInterface
{
    public interface IVehicle
    {
        public List<VehicleViewModel> GetAllVehicles();
        public VehicleViewModel GetVehicleById(int id);
        public void AddVehicle(VehicleViewModel vehicle);
        public void UpdateVehicle(VehicleViewModel vehicle);
        public void DeleteVehicle(int id);


    }
}
