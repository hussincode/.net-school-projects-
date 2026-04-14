using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_System.Models
{
    public class ServiceType
    {
        [Key]
        public int ServiceTypeId { get; set; }
        public string Name { get; set; }    
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<BookingRecord> Bookings { get; set; }
    }
}
