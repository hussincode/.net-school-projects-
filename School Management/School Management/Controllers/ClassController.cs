using Microsoft.AspNetCore.Mvc;

namespace School_Management.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
