using Microsoft.AspNetCore.Mvc;
using Restaurant_Management_Demo2.Models;
using Restaurant_Management_Demo2.Models.Repo.RepoInterface;
using Restaurant_Management_Demo2.Models.Vewmodel;

namespace Restaurant_Management_Demo2.Controllers
{
    public class OrderController : Controller
    {

        
            private readonly IOrder _orderRepo;
            private readonly IMenuItem _menuItemRepo;

            public OrderController(IOrder orderRepo, IMenuItem menuItemRepo)
            {
                _orderRepo = orderRepo;
                _menuItemRepo = menuItemRepo;
            }

            public IActionResult Index() => View(_orderRepo.GetAll());

            [HttpGet]
            public IActionResult Create()
            {
                var vm = new OrderViewModel { MenuItems = _menuItemRepo.GetAll() };
                return View(vm);
            }

            [HttpPost]
            public IActionResult Create(OrderViewModel vm)
            {
                
                    var order = new Order
                    {
                        Quantity = vm.Quantity,
                        MenuItemId = vm.MenuItemId,
                        OrderDate = DateOnly.MinValue
                    };
                    _orderRepo.Add(order);
                    return RedirectToAction("Index");
           
            }
        
    }
}
