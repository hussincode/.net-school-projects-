using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfSeats { get; set; }
        [ForeignKey("Showtime")]
        public int ShowtimeId { get; set; }
        public Showtime Showtime { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
