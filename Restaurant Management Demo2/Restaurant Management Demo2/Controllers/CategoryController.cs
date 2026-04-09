using Microsoft.AspNetCore.Mvc;
using Restaurant_Management_Demo2.Models;
using Restaurant_Management_Demo2.Models.Repo.RepoClas;
using Restaurant_Management_Demo2.Models.Repo.RepoInterface;

namespace Restaurant_Management_Demo2.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ICategory _category;
        public CategoryController(ICategory category) 
        {
            _category = category;
        }
        public IActionResult Index() => View(_category.GetAll());

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Category category)
        {
            
                _category.GetAdd(category);
                return RedirectToAction("Index");
            
        
        }


        

    }
}
