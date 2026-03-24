using Clinc_Mang.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinc_Mang.Controllers
{
    public class PatientController : Controller
    {
        private APPDBcontext _context = new APPDBcontext();
        public IActionResult Index()
        {
            var patient = _context.Patients.ToList();
            return View(patient);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
