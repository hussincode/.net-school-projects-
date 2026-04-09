using Vehicle_Maintenance_Management.Models.Repo.RepoInterface;

namespace Vehicle_Maintenance_Management.Models.Repo.RerpoClass
{
    public class VehicleRepo : IVehicle
    {
        public readonly VehicleContext _context;
        public VehicleRepo(VehicleContext context)
        {
            _context = context;
        }   

        public List<VehicleViewModel> GetAllVehicles()
        {
            return _context.Vehicles.Select(a => new VehicleViewModel
            {
                VehicleId = a.VehicleId,
                PlateNumber = a.PlatNumber,
                Brand = a.Brand,
                Model = a.Model, // Fix: Convert int to string
                Year = a.Year,
                OwnerName = a.Owner.Name
            }).ToList();
        }

        public VehicleViewModel GetVehicleById(int id)
        {
            var record = _context.Vehicles.Find(id);
            if (record == null) return null;

            return new VehicleViewModel
            {
                VehicleId = record.VehicleId,
                PlateNumber = record.PlatNumber,
                Brand = record.Brand,
                Model = record.Model, // Fix: Convert int to string
                Year = record.Year,
                OwnerName = record.Owner.Name
            };
        }
        public void AddVehicle(VehicleViewModel vehicle)
        {
            var entity = new Vehicle
            {
                PlatNumber = vehicle.PlateNumber,
                Brand = vehicle.Brand,
                Model = vehicle.Model,
                Year = vehicle.Year,
                OwnerId = vehicle.UserId // assuming you added UserId in VehicleViewModel
            };

            _context.Vehicles.Add(entity);
            _context.SaveChanges();
        }
        public void UpdateVehicle(Vehicle vehicle)
        {
            var data = _context.Vehicles.Find(vehicle.VehicleId);
            if (data != null)
            {
                data.PlatNumber = vehicle.PlatNumber;
                data.Brand = vehicle.Brand;
                data.Model = vehicle.Model;
                data.Year = vehicle.Year;
                data.OwnerId = vehicle.OwnerId;
                _context.SaveChanges();
            }
        }
        public void DeleteVehicle(int id)
        {
            var data = _context.Vehicles.Find(id);
            if (data != null)
            {
                _context.Vehicles.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
