using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Specialization { get; set; }
        [Required]
        [StringLength(11)]
        public string PhoneNumber { get; set; }
        [Required]
        public string HireDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Class> Classes { get; set; }
    }
}
