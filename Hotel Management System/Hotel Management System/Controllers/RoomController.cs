using Hotel_Management_System.Models.VM;
using Hotel_Management_System.Repo.RepoInterface;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Management_System.Controllers
{
    public class RoomController : Controller
    {

        
            private readonly IRooms _roomRepo;
            private readonly IUsers _userRepo;

            public RoomController(IRooms roomRepo, IUsers userRepo)
            {
                _roomRepo = roomRepo;
                _userRepo = userRepo;
            }

            public IActionResult Index()
            {
                var rooms = _roomRepo.GetAll();
                return View(rooms);
            }

            public IActionResult Create()
            {
                var vm = new RoomVM
                {
                    UserId = 0
                };
                ViewBag.Users = _userRepo.GetAll();
                return View(vm);
            }

            [HttpPost]
            public IActionResult Create(RoomVM vm)
            {
                if (ModelState.IsValid)
                {
                    _roomRepo.Add(vm);
                    return RedirectToAction("Index");
                }

                ViewBag.Users = _userRepo.GetAll();
                return View(vm);
            }

            public IActionResult Edit(int id)
            {
                var room = _roomRepo.GetById(id);
                if (room == null) return NotFound();

                var vm = new RoomVM
                {
                    RoomId = room.RoomId,
                    RoomNumber = room.RoomNumber,
                    Type = room.Type,
                    PricePerNight = room.PricePerNight,
                    Status = room.Status,
                    UserId = room.UserId
                };

                ViewBag.Users = _userRepo.GetAll();
                return View(vm);
            }

            [HttpPost]
            public IActionResult Edit(RoomVM vm)
            {
                if (ModelState.IsValid)
                {
                    _roomRepo.Update(vm);
                    return RedirectToAction("Index");
                }

                ViewBag.Users = _userRepo.GetAll();
                return View(vm);
            }

            public IActionResult Delete(int id)
            {
                var room = _roomRepo.GetById(id);
                if (room == null) return NotFound();
                    
                return View(room);
            }

            [HttpPost, ActionName("Delete")]
            public IActionResult DeleteConfirmed(int id)
            {
                _roomRepo.Delete(id);
                return RedirectToAction("Index");
            }
        }
    }

