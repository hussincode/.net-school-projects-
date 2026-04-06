using Attendance.Models;
using Microsoft.AspNetCore.Mvc;

namespace Attendance.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly IAttendance _attendanceRepo;
        private readonly Istudent _studentRepo;
        private readonly Isubject _subjectRepo;
        public AttendanceController(IAttendance attendanceRepo, Istudent istudent, Isubject isubject)
        {
            _attendanceRepo = attendanceRepo;
            _studentRepo = istudent;
            _subjectRepo = isubject;


        }

        public IActionResult Index()
        {
            var data = _attendanceRepo.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var vm = new VM
            {
                StudentList = _studentRepo.GetAll(),
                SubjectList = _subjectRepo.GetAll()
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VM vM)
        {


            var attendance = new Attendancem
            {
                StudentId = vM.StudentId,
                SubjectId = vM.SubjectId,
                Status = vM.Status,
                date = vM.date
            };

            _attendanceRepo.ADD(attendance);
 
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var attendance = _attendanceRepo.GetById(id);
            if (attendance == null) return NotFound();
             
            var vm = new VM
            {
                StudentId = attendance.StudentId,
                SubjectId = attendance.SubjectId,
                Status = attendance.Status,
                date = attendance.date,
         
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, VM vM)
        {
            var attendance = _attendanceRepo.GetById(id);
            if (attendance == null) return NotFound();

            attendance.StudentId = vM.StudentId;
            attendance.SubjectId = vM.SubjectId;
            attendance.Status = vM.Status;
            attendance.date = vM.date;

            _attendanceRepo.UPDATE(attendance);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var attendance = _attendanceRepo.GetById(id);
            if (attendance == null) return NotFound();

            return View(attendance);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var attendance = _attendanceRepo.GetById(id);
            if (attendance == null) return NotFound();

            _attendanceRepo.Delete(attendance);

            return RedirectToAction("Index");
        }
    }
}
