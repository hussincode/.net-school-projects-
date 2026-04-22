using Club_Management.Models;
using Club_Management.Models.VM;
using System.Diagnostics;

namespace Club_Management.Repo.RepoInterface
{
    public interface IRegistrations
    {
        public List<Registration> GetAllRegistrations();
        public Registration GetRegistrationById(int id);
        List<Member> GetAllMembers();
        List<ActivityModel> GetAllActivities();
        public void AddRegistration(RegistrationVM registration);
        public void UpdateRegistration(RegistrationVM registration);
        public void DeleteRegistration(int id);
    }
}
