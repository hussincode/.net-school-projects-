namespace Hotel_Management_System.Models.VM
{
    public class BookingRecordsVM
    {
        public int BookingRecordId { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Notes { get; set; }
        public int RoomId { get; set; }
        public List<BookingRecord> BookingRecords { get; set; }
    }
}
