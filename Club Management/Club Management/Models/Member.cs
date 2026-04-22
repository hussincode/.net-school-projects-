namespace Club_Management.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Registration> Registrations { get; set; }
    }
}
