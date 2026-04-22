namespace Cinema.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public int ReleaseYear { get; set; }
        public List<Showtime> Showtimes { get; set; }   
    }
}
