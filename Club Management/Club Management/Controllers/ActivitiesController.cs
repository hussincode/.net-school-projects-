using Club_Management.Repo.RepoClass;
using Club_Management.Repo.RepoInterface;
using Microsoft.AspNetCore.Mvc;

namespace Club_Management.Controllers
{
    public class ActivitiesController : Controller
    {
        public readonly IActivities _activitiesRepo;
        public ActivitiesController(IActivities activitiesRepo)
        {
            _activitiesRepo = activitiesRepo;
        }

        public IActionResult Index()
        {
            var activities = _activitiesRepo.GetAllActivities();
            return View(activities);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }



        


        [HttpPost]
        public IActionResult Create(Models.ActivityModel activity)
        {
           
                _activitiesRepo.AddActivity(activity);
                return RedirectToAction("Index");
            
            return View(activity);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var activity = _activitiesRepo.GetActivityById(id);
            if (activity == null)
            {
                return NotFound();
            }
            return View(activity);
        }

        [HttpPost]
        public IActionResult Edit(Models.ActivityModel activity)
        {
           
                _activitiesRepo.UpdateActivity(activity);
                return RedirectToAction("Index");
            
            return View(activity);
        }

        public IActionResult Delete(int id)
        {
            _activitiesRepo.DeleteActivity(id);
            return RedirectToAction("Index");
        }
    }
}
