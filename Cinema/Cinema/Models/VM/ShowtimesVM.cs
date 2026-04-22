using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Models.VM
{
    public class ShowtimesVM
    {
        public int ShowtimeId { get; set; }
        public DateTime StartTime { get; set; }
        [ForeignKey("Hall")]
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public List<Booking> Bookings { get; set; }
         
    }
}
