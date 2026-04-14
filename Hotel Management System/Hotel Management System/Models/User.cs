using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_System.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public List<Room> Rooms { get; set; }
        public List<BookingRecord> Bookings { get; set; }
        public List<ServiceType> ServiceTypes { get; set; }
    }
}
