using Restaurant_Management_Demo2.Models.Repo.RepoInterface;

namespace Restaurant_Management_Demo2.Models.Repo.RepoClas
{
    public class CategoryRepo : ICategory
    {
        public readonly RestaurantManagementContext _context;
        public CategoryRepo(RestaurantManagementContext context)
        {
            _context = context;
        }

        public List<Category> GetAll()
        {
            var data = _context.Category.ToList();
            return data;
         
        }

        public Category GetById(int id)
        {
            var data  = _context.Category.FirstOrDefault(o => o.CategoryId == id);
            return data;
        }

        public void GetAdd(Category category)
        {
            

            _context.Category.Add(category);
            _context.SaveChanges();

        }
    }
}
