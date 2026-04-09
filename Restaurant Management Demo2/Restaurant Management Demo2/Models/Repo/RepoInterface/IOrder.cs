namespace Restaurant_Management_Demo2.Models.Repo.RepoInterface
{
    public interface IOrder
    {
        List<Order> GetAll();
        Order GetById(int id);
        void Add(Order order);
    }
}
