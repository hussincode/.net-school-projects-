using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        [StringLength(11)]
        public string PhoneNumber { get; set; }
        public List<Teacher> teachers { get; set; }
        public List<Student> students { get; set; }
        public List<Class> classes { get; set; }    
    }
}
