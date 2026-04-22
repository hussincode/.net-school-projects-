using Club_Management.Models;
using Club_Management.Repo.RepoInterface;

namespace Club_Management.Repo.RepoClass
{
    public class ActivitiesRepo : IActivities
    {
        public readonly ClubContext _context;
        public ActivitiesRepo(ClubContext context)
        {
            _context = context;
        }

        public ActivityModel GetActivityById(int id)
        {
            return _context.Activities.FirstOrDefault(a => a.ActivityId == id);
        }
        public List<ActivityModel> GetAllActivities()
        {
            return _context.Activities.ToList();
        }
        public void AddActivity(ActivityModel activity)
        {
            _context.Activities.Add(activity);
            _context.SaveChanges();
        }

        public void UpdateActivity(ActivityModel activity)
        {
            _context.Activities.Update(activity);
            _context.SaveChanges();
        }

        public void DeleteActivity(int id)
        {
            var activity = _context.Activities.FirstOrDefault(a => a.ActivityId == id);
            if (activity != null)
            {
                _context.Activities.Remove(activity);
                _context.SaveChanges();
            }
        }
    }
}
