namespace Hotel_Management_System.Models.VM
{
    public class RoomVM
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public decimal PricePerNight { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public List<User> User { get; set; }
    }
}
