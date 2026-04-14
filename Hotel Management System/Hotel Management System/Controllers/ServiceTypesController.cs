using Hotel_Management_System.Models.VM;
using Hotel_Management_System.Repo.RepoInterface;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Management_System.Controllers
{
    public class ServiceTypesController : Controller
    {
        private readonly IServiceTypes _serviceTypesRepo;
        private readonly IUsers _userRepo;

        public ServiceTypesController(IServiceTypes serviceTypesRepo, IUsers userRepo)
        {
            _serviceTypesRepo = serviceTypesRepo;
            _userRepo = userRepo;
        }

        public IActionResult Index()
        {
            var services = _serviceTypesRepo.GetAll();
            return View(services);
        }

        public IActionResult Create()
        {
            var vm = new ServiceTypesVM
            {
                UserId = 0
            };
            ViewBag.Users = _userRepo.GetAll();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(ServiceTypesVM vm)
        {
            if (ModelState.IsValid)
            {
                _serviceTypesRepo.Add(vm);
                return RedirectToAction("Index");
            }

            ViewBag.Users = _userRepo.GetAll();
            return View(vm);
        }

        public IActionResult Edit(int id)
        {
            var service = _serviceTypesRepo.GetById(id);
            if (service == null) return NotFound();

            var vm = new ServiceTypesVM
            {
                ServiceTypeId = service.ServiceTypeId,
                Name = service.Name,
                Price = service.Price,
                UserId = service.UserId
            };

            ViewBag.Users = _userRepo.GetAll();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(ServiceTypesVM vm)
        {
            if (ModelState.IsValid)
            {
                _serviceTypesRepo.Update(vm);
                return RedirectToAction("Index");
            }

            ViewBag.Users = _userRepo.GetAll();
            return View(vm);
        }

        public IActionResult Delete(int id)
        {
            var service = _serviceTypesRepo.GetById(id);
            if (service == null) return NotFound();

            return View(service);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _serviceTypesRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
