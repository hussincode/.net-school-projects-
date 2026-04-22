using canten.Models;
using canten.Repo.RepoInterface;
using Microsoft.EntityFrameworkCore;

namespace canten.Repo.RepoClass
{
    public class StaffRepo : IStaff
    {
        public readonly CanteenContext _context;
        public StaffRepo(CanteenContext context)
        {
            this._context = context;
        }

        
   

            public List<Staff> GetAllStaffs()
            {
                return _context.Staffs
                               .Include(s => s.User)
                               .Include(s => s.Orders)
                               .ToList();
            }

            public Staff GetById(int id)
            {
                return _context.Staffs
                               .Include(s => s.User)
                               .Include(s => s.Orders)
                               .FirstOrDefault(s => s.StaffId == id);
            }

            public Staff CreateStaff(Staff staff)
            {
                _context.Staffs.Add(staff);
                _context.SaveChanges();
                return staff;
            }

            public Staff UpdateStaff(Staff staff)
            {
                _context.Staffs.Update(staff);
                _context.SaveChanges();
                return staff;
            }

            public void DeleteStaff(int id)
            {
                var staff = _context.Staffs.Find(id);
                if (staff != null)
                {
                    _context.Staffs.Remove(staff);
                    _context.SaveChanges();
                }
            }
        }
    }

