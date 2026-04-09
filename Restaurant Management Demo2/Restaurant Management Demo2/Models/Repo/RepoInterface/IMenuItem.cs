namespace Restaurant_Management_Demo2.Models.Repo.RepoInterface
{
    public interface IMenuItem
    {
        List<MenuItem> GetAll();
        MenuItem GetById(int id);
        void Add(MenuItem menuItem);
    }
}
