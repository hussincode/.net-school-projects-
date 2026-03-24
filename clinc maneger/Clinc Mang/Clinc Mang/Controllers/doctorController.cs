using AspNetCoreGeneratedDocument;
using Clinc_Mang.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinc_Mang.Controllers
{
    public class doctorController : Controller
    {

        private APPDBcontext _context = new APPDBcontext();
        public IActionResult Index()
        {
            var doctor = _context.Doctors.ToList();
            return View(doctor);
        }
        //make the user add doctor to the database from the view
        [HttpGet]
        public async Task<IActionResult> Add(int id)
        {
                return View();
        }


        [HttpPost]
        public IActionResult Add(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
