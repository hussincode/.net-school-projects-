using Cinema.Models;

namespace Cinema.Repo.RepoInterface
{
    public interface IHall
    {
        List<Hall> GetAllAsync();
        Hall GetByIdAsync(int id);
        void AddAsync(Hall hall);
        void UpdateAsync(Hall hall);
        void DeleteAsync(int id);

        // Extra functionality
        int GetCapacityAsync(int hallId);
    }
}
