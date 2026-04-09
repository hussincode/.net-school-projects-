using Restaurant_Management_Demo2.Models.Repo.RepoInterface;

namespace Restaurant_Management_Demo2.Models.Repo.RepoClas
{
    public class OrderRepo : IOrder
    {
        public readonly RestaurantManagementContext _context;
        public OrderRepo(RestaurantManagementContext context)
        {
            _context = context;
        }

        public List<Order> GetAll() => _context.Order.ToList();
        public Order GetById(int id) => _context.Order.FirstOrDefault(o => o.OrderId == id);
        public void Add(Order order)
        {
            _context.Order.Add(order);
            _context.SaveChanges();
        }
    }
}
