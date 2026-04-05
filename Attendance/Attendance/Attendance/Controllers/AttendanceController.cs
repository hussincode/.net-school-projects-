using Attendance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Attendance.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly Attendancecontext _context;
        public AttendanceController(Attendancecontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Attendances.Include(a => a.Student).Include(a => a.Subject).ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var vm = new VM
            {
                StudentList = _context.Students.ToList(),
                SubjectList = _context.Subjects.ToList()
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VM vM)
        {
            var attendance = new Models.Attendance
            {
                StudentId = vM.StudentId,
                SubjectId = vM.SubjectId,
                Status = vM.Status,
                date = DateOnly.FromDateTime(DateTime.Now)
            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        // GET: Attendance/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var attendance = _context.Attendances.Find(id);
            if (attendance == null)
            {
                return NotFound();
            }

            var vm = new VM
            {
                StudentId = attendance.StudentId,
                SubjectId = attendance.SubjectId,
                Status = attendance.Status,
                date = DateOnly.FromDateTime(DateTime.Now),
                StudentList = _context.Students.ToList(),
                SubjectList = _context.Subjects.ToList()
            };

            return View(vm);
        }

        // POST: Attendance/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, VM vM)
        {
            var attendance = _context.Attendances.Find(id);
            if (attendance == null)
            {
                return NotFound();
            }

            attendance.StudentId = vM.StudentId;
            attendance.SubjectId = vM.SubjectId;
            attendance.Status = vM.Status;
            attendance.date = vM.date;

            _context.Update(attendance);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Attendance/Delete/5
        public IActionResult Delete(int id)
        {
            var attendance = _context.Attendances
                .Include(a => a.Student)
                .Include(a => a.Subject)
                .FirstOrDefault(a => a.SubjectId == id);

            if (attendance == null)
            {
                return NotFound();
            }

            return View(attendance);
        }

        // POST: Attendance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var attendance = _context.Attendances.Find(id);
            if (attendance == null)
            {
                return NotFound();
            }

            _context.Attendances.Remove(attendance);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
