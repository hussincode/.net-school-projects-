using System.ComponentModel.DataAnnotations.Schema;

namespace Club_Management.Models
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public int RegistraFadytionId { get; set; }

        [ForeignKey("Member")]
        public int MemberId { get; set; }
        [ForeignKey("Activity")]

        public int ActivityId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Member Member { get; set; }
        public ActivityModel Activity { get; set; }
    }
}
