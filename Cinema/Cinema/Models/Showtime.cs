using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Models
{
    public class Showtime
    {
        public int ShowtimeId { get; set; }
        public DateTime StartTime { get; set; }

        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public int HallId { get; set; }
        public string HallName { get; set; }

    }
}
