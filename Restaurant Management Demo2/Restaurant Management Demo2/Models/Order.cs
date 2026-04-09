namespace Restaurant_Management_Demo2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public DateOnly OrderDate {  get; set; }    
        public int MenuItemId { get; set; }
        public MenuItem  MenuItem { get; set; }
    }
}
