using canten.Models;

namespace canten.Repo.RepoInterface
{
    public interface IOrder
    {
        public List<Order> GetAllOrders();
        public Order GetById(int id);
        public Order CreateOrder(Order order);
        public Order UpdateOrder(Order order);
        public void DeleteOrder(int id);
    }
}
