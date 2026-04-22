namespace Cinema.Models.VM
{
    public class BookingVM
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfSeats { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int ShowtimeId { get; set; }
        public string MovieTitle { get; set; }
        public DateTime ShowtimeStart { get; set; }
    }
}
