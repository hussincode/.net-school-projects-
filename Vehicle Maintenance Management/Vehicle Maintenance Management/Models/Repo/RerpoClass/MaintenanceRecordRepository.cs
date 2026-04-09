using Vehicle_Maintenance_Management.Models.Repo.RepoInterface;

namespace Vehicle_Maintenance_Management.Models.Repo.RerpoClass
{
    public class MaintenanceRecordRepository : IMaintenanceRecordRepository
    {

        private readonly VehicleContext _context;

        public MaintenanceRecordRepository(VehicleContext context)
        {
            _context = context;
        }

        public List<MaintenanceRecordViewModel> GetAll()
        {
            return _context.MaintenanceRecords
                .Select(a => new MaintenanceRecordViewModel
                {
                    MaintenanceRecordId = a.MaintenanceRecordId,
                    VehicleId = a.VehicleId,
                    MaintenanceTypeId = a.MaintenanceTypeId,
                    ServiceDate = a.ServiceDate,
                    CurrentKm = a.CurrentKm,
                    Notes = a.Notes,
                    VehiclePlate = a.Vehicle.PlatNumber,          // include plate
                    MaintenanceTypeName = a.MaintenanceType.Name   // include type name
                }).ToList();
        }

        public MaintenanceRecordViewModel GetById(int id)
        {
            var record = _context.MaintenanceRecords
                .Where(r => r.MaintenanceRecordId == id)
                .Select(r => new MaintenanceRecordViewModel
                {
                    MaintenanceRecordId = r.MaintenanceRecordId,
                    VehicleId = r.VehicleId,
                    MaintenanceTypeId = r.MaintenanceTypeId,
                    ServiceDate = r.ServiceDate,
                    CurrentKm = r.CurrentKm,
                    Notes = r.Notes,
                    VehiclePlate = r.Vehicle.PlatNumber,
                    MaintenanceTypeName = r.MaintenanceType.Name
                })
                .FirstOrDefault();

            return record;
        }

        public void Add(MaintenanceRecord record)
        {
            _context.MaintenanceRecords.Add(record);
            _context.SaveChanges();
        }

        public void Update(MaintenanceRecord record)
        {
            _context.MaintenanceRecords.Update(record);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var record = _context.MaintenanceRecords.Find(id);
            if (record != null)
            {
                _context.MaintenanceRecords.Remove(record);
                _context.SaveChanges();
            }
        }
    }
}
