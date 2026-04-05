using Attendance.Migrations;
using Attendance.Models;
using Microsoft.AspNetCore.Mvc;

namespace Attendance.Controllers
{
    public class StudentsController : Controller
    {
        private readonly Attendancecontext _context;
        public StudentsController(Attendancecontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Students.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Student student)
        {
            
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            _context.Students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
