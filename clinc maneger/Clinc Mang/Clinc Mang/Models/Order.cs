namespace Clinc_Mang.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
