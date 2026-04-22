using System.ComponentModel.DataAnnotations;

namespace School_Management.Models.VM
{
    public class StudentsVM
    {
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(11)]
        public string Phone { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
