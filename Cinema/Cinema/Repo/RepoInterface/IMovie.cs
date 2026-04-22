using Cinema.Models;

namespace Cinema.Repo.RepoInterface
{
    public interface IMovie
    {
        List<Movie> GetAll();
        Movie GetById(int id);
        public void Add(Movie movie);
        public void Update(Movie movie);
        public void Delete(int id);

        List<Movie> SerchByTitle(string title); 
    }
}
