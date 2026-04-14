namespace Hotel_Management_System.Models.VM
{
    public class ServiceTypesVM
    {
        public int ServiceTypeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public List<User> users { get; set; }
    }
}
