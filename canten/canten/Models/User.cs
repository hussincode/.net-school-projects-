using System.ComponentModel.DataAnnotations;

namespace canten.Models
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
        [MinLength(11)]
        [MaxLength(11)]
        public string Phone { get; set; }
        public string Role { get; set; } 

        public List<Order> Orders { get; set; }
         public List<FoodItem> FoodItems { get; set; }
         public List<Staff> Staffs { get; set; }
    }
}
