using Hotel_Management_System.Models;
using Hotel_Management_System.Repo.RepoInterface;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Management_System.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsers _userRepo;

        public UserController(IUsers userRepo)
        {
            _userRepo = userRepo;
        }

        public IActionResult Index()
        {
            var users = _userRepo.GetAll();
            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _userRepo.Add(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public IActionResult Edit(int id)
        {
            var user = _userRepo.GetById(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _userRepo.Update(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public IActionResult Delete(int id)
        {
            var user = _userRepo.GetById(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _userRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
