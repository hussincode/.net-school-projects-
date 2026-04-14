using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_System.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public decimal PricePerNight { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<BookingRecord> Bookings { get; set; }
    }
}
