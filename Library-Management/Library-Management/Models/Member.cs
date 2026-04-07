using System.ComponentModel.DataAnnotations;

namespace Library_Management.Models
{
    public class Member
    {
        [Key]
        public int memberId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
}
