using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace canten.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Status { get; set; }
        [Required]
        public string JobTitle { get; set; }
            [Required]
            [MinLength(11)]
            [MaxLength(11)]
        public string Phone { get; set; }

       
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }  
        public List<Order> Orders { get; set; }
    }
}
