using System.ComponentModel.DataAnnotations.Schema;

namespace canten.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal TotalPrice    { get; set; }
        public DateTime OrderDateTime { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public  int UserId { get; set; }
        [ForeignKey("FoodItemId")]
        public FoodItem FoodItem { get; set; }
        public int FoodItemId { get; set; }
        [ForeignKey("StaffId")]
        public Staff Staff { get; set; }
        public int StaffId { get; set; }
    }
}
