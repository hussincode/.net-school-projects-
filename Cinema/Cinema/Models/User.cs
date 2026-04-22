using System.ComponentModel.DataAnnotations;

namespace Cinema.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone must be 11 digits")]
        public string Phone { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
