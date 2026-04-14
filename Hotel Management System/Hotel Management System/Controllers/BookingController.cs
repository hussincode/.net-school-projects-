using Hotel_Management_System.Models;
using Hotel_Management_System.Models.VM;
using Hotel_Management_System.Repo.RepoInterface;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Management_System.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingRecords _bookingRecordRepo;
        private readonly IRooms _roomRepo;

        public BookingController(IBookingRecords bookingRecordRepo, IRooms roomRepo)
        {
            _bookingRecordRepo = bookingRecordRepo;
            _roomRepo = roomRepo;
        }

        public IActionResult Index()
        {
            var bookings = _bookingRecordRepo.GetAll();
            return View(bookings);
        }

        public IActionResult Create()
        {
            var vm = new BookingRecordsVM
            {
                BookingRecords = new List<BookingRecord>(),
                RoomId = 0
            };
            ViewBag.Rooms = _roomRepo.GetAll();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(BookingRecordsVM vm)
        {
            if (ModelState.IsValid)
            {
                _bookingRecordRepo.Add(vm);
                return RedirectToAction("Index");
            }

            ViewBag.Rooms = _roomRepo.GetAll();
            return View(vm);
        }

        
        public IActionResult Edit(int id)
        {
            var booking = _bookingRecordRepo.GetById(id);
            if (booking == null) return NotFound();

            ViewBag.Rooms = _roomRepo.GetAll();
            return View(booking);
        }

        [HttpPost]
        public IActionResult Edit(BookingRecordsVM vm)
        {
            if (ModelState.IsValid)
            {
                _bookingRecordRepo.Update(vm);
                return RedirectToAction("Index");
            }

            ViewBag.Rooms = _roomRepo.GetAll();
            return View(vm);
        }

        public IActionResult Delete(int id)
        {
            var booking = _bookingRecordRepo.GetById(id);
            if (booking == null) return NotFound();

            return View(booking);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _bookingRecordRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
