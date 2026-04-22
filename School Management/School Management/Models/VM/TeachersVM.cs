using System.ComponentModel.DataAnnotations;

namespace School_Management.Models.VM
{
    public class TeachersVM
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string PhoneNumber { get; set; }
        public string HireDate { get; set; }
        public int UserId { get; set; }
        public List<User> Users { get; set; }
    }
}
