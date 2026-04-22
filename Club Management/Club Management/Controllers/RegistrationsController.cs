using Club_Management.Models;
using Club_Management.Models.VM;
using Club_Management.Repo.RepoClass;
using Club_Management.Repo.RepoInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Club_Management.Controllers
{
    public class RegistrationsController : Controller
    {
        public readonly IRegistrations _registrationsRepo;
        public RegistrationsController(IRegistrations registrationsRepo)
        {
            _registrationsRepo = registrationsRepo;
        }
        public IActionResult Index()
        {
            var data = _registrationsRepo.GetAllRegistrations();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // 1. Initialize the VM
            var vm = new RegistrationVM
            {
                // 2. Fetch the data for the dropdowns
                // NOTE: Use a method that gets ALL members/activities, not just existing registrations
                Members = _registrationsRepo.GetAllMembers(),
                Activities = _registrationsRepo.GetAllActivities(),
                RegistrationDate = DateTime.Now // Set a default date
            };

            // DO NOT call _registrationsRepo.AddRegistration here. 
            // This method is just to SHOW the empty form.

            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(RegistrationVM vM)
        {
            if (ModelState.IsValid)
            {
                // Save only when the user submits a valid form
                _registrationsRepo.AddRegistration(vM);
                return RedirectToAction("Index");
            }

            // If validation fails, reload the dropdowns from the Repo
            vM.Members = _registrationsRepo.GetAllMembers();
            vM.Activities = _registrationsRepo.GetAllActivities();

            return View(vM);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var registration = _registrationsRepo.GetRegistrationById(id);
            if (registration == null) return NotFound();

            var vm = new RegistrationVM
            {
                RegistrationVMId = registration.RegistrationId,
                MemberId = registration.MemberId,
                ActivityId = registration.ActivityId,
                RegistrationDate = registration.RegistrationDate,
                // YOU MUST ADD THESE:
                Members = _registrationsRepo.GetAllMembers(),
                Activities = _registrationsRepo.GetAllActivities()
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(Models.VM.RegistrationVM registration)
        {
            if (ModelState.IsValid)
            {
                _registrationsRepo.UpdateRegistration(registration);
                return RedirectToAction("Index");
            }
            return View(registration);
        }
        
        public IActionResult Delete(Models.Registration registration)
        {
            _registrationsRepo.DeleteRegistration(registration.RegistrationId);
            return RedirectToAction("Index");
        }
    }
}
