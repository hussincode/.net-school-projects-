using Club_Management.Models;
using Club_Management.Repo.RepoInterface;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Club_Management.Repo.RepoClass
{
    public class RegistrationsRepo : IRegistrations
    {
        public readonly ClubContext _context;
        public RegistrationsRepo(ClubContext context)
        {
            _context = context;
        }
        public void AddRegistration(Models.VM.RegistrationVM registration)
        {
            // Check if values actually exist before calling .Value
            if (!registration.MemberId.HasValue || !registration.ActivityId.HasValue)
            {
                throw new Exception("Member or Activity was not selected.");
            }

            var newRegistration = new Models.Registration
            {
                MemberId = registration.MemberId.Value,
                ActivityId = registration.ActivityId.Value,
                RegistrationDate = registration.RegistrationDate
            };

            _context.Registrations.Add(newRegistration);
            _context.SaveChanges();
        }
        public void DeleteRegistration(int id)
        {
            var registration = _context.Registrations.FirstOrDefault(r => r.RegistrationId == id);
            if (registration != null)
            {
                _context.Registrations.Remove(registration);
                _context.SaveChanges();
            }
        }
        public List<Models.Registration> GetAllRegistrations()
        {
            return _context.Registrations.Include(o => o.Member).Include(o => o.Activity).ToList();
        }
        public Models.Registration GetRegistrationById(int id)
        {
            return _context.Registrations.FirstOrDefault(r => r.RegistrationId == id);
        }
        public List<Member> GetAllMembers()
        {
            return _context.Members.ToList();
        }

        public List<ActivityModel> GetAllActivities() => _context.Activities.ToList();
        public void UpdateRegistration(Models.VM.RegistrationVM registration)
        {
            var existingRegistration = _context.Registrations.FirstOrDefault(r => r.RegistrationId == registration.RegistrationVMId);
            if (existingRegistration != null)
            {
                existingRegistration.MemberId = registration.MemberId??0;
                existingRegistration.ActivityId = registration.ActivityId??0;
                existingRegistration.RegistrationDate = registration.RegistrationDate;
                _context.SaveChanges();
            }
        }
    }
}
