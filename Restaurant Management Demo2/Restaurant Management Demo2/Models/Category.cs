namespace Restaurant_Management_Demo2.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string name { get; set; }
        public List<MenuItem> MenuItems { get; set; }
    }
}
