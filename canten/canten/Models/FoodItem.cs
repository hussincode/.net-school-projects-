using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace canten.Models
{
    public class FoodItem
    {
        [Key]
        public int FoodItemId { get; set; } 
        [Required]

        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        
        public string Category { get; set; }

            [ForeignKey("CreatedByUserId")]
        public int CreatedByUserId { get; set; }
         public User User { get; set; }

        public List<Order> Orders { get; set; }
    }
}
