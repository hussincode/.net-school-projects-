using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_System.Models
{
    public class BookingRecord
    {
        [Key]
        public int BookingRecordId { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Notes { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }

    }
}
