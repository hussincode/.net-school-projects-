using Attendance.Models;
using Microsoft.AspNetCore.Mvc;

namespace Attendance.Controllers
{
    public class SubjectsController : Controller
    {
        private readonly Attendancecontext _context;

        public SubjectsController(Attendancecontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Subjects.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var subject = _context.Subjects.Find(id);
            if (subject == null)
            {
                return NotFound();
            }
            return View(subject);
        }

        [HttpPost]
        public IActionResult Edit(Subject subject)
        {
            _context.Subjects.Update(subject);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var subject = _context.Subjects.Find(id);
            if (subject == null)
            {
                return NotFound();
            }
            _context.Subjects.Remove(subject);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
