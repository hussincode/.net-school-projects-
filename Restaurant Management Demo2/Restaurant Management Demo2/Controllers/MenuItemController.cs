using Microsoft.AspNetCore.Mvc;
using Restaurant_Management_Demo2.Models;
using Restaurant_Management_Demo2.Models.Repo.RepoInterface;
using Restaurant_Management_Demo2.Models.Vewmodel;

namespace Restaurant_Management_Demo2.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly IMenuItem _menuItemRepo;
        private readonly ICategory _categoryRepo;

        public MenuItemController(IMenuItem menuItemRepo, ICategory categoryRepo)
        {
            _menuItemRepo = menuItemRepo;
            _categoryRepo = categoryRepo;
        }

        public IActionResult Index() => View(_menuItemRepo.GetAll());

        public IActionResult Create()
        {
            var vm = new MenuItemCreateViewModel
            {
                Categories = _categoryRepo.GetAll()
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(MenuItemCreateViewModel vm)
        {
            
                var menuItem = new MenuItem
                {
                    MenuItemName = vm.Name,
                    price = vm.Price,
                    CategoryId = vm.CategoryId,
                    MenuItemId = vm.MenuItemId
                };

                _menuItemRepo.Add(menuItem);
                return RedirectToAction("Index");
            

           
        }


    }


}

