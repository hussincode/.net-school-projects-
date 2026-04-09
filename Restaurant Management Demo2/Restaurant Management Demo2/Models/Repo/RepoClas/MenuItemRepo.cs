using Microsoft.EntityFrameworkCore;
using Restaurant_Management_Demo2.Models.Repo.RepoInterface;

namespace Restaurant_Management_Demo2.Models.Repo.RepoClas
{
    public class MenuItemRepo : IMenuItem
    {
        public RestaurantManagementContext _context;
        public MenuItemRepo(RestaurantManagementContext context)
        {
            _context = context;
        }

        public List<MenuItem> GetAll() => _context.MenuItem.ToList();
        public MenuItem GetById(int id) => _context.MenuItem.FirstOrDefault(m => m.MenuItemId == id);
        public void Add(MenuItem menuItem)
        {
            _context.MenuItem.Add(menuItem);
            _context.SaveChanges();
        }
    }
}
