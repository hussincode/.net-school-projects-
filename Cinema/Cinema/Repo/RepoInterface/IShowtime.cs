using Cinema.Models;

namespace Cinema.Repo.RepoInterface
{
    public interface IShowtime
    {
        List<Showtime> GetAllAsync();
        Showtime GetByIdAsync(int id);
        void AddAsync(Showtime showtime);
        void UpdateAsync(Showtime showtime);
        void DeleteAsync(int id);
    }
}
