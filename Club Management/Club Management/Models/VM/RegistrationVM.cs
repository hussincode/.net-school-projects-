namespace Club_Management.Models.VM
{
    public class RegistrationVM
    {
        public int RegistrationVMId { get; set; }
        public int? MemberId { get; set; }
        public int? ActivityId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public List<Member> Members { get; set; }
        public List<ActivityModel> Activities { get; set; }
    }
}
