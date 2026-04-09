namespace Restaurant_Management_Demo2.Models.Vewmodel
{
    public class OrderViewModel
    {
      
            public int Quantity { get; set; }
            public int MenuItemId { get; set; }
            public List<MenuItem> MenuItems { get; set; }
        
    }
}
