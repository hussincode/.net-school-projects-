using Club_Management.Models;

namespace Club_Management.Repo.RepoInterface
{
    public interface IActivities
    {
        public List<ActivityModel> GetAllActivities();
        public ActivityModel GetActivityById(int id);
        public void AddActivity(ActivityModel activity);
        public void UpdateActivity(ActivityModel activity);
        public void DeleteActivity(int id);
    }
}
