namespace Restaurant_Management_Demo2.Models.Vewmodel
{
    public class MenuItemCreateViewModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
        public int CategoryId { get; set; }
        public List<Category> Categories { get; set; }
    }
}
