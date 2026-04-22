using Club_Management.Models;
using Club_Management.Repo.RepoClass;
using Club_Management.Repo.RepoInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Club_Management.Controllers
{
    public class MembersController : Controller
    {
       
        public readonly IMember _membersRepo;
        public MembersController(IMember membersRepo)
        {
            _membersRepo = membersRepo;
        }

        public ActionResult Index()
        {
            var members = _membersRepo.GetAllMembers();
            return View(members);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: MembersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            var existingMember = _membersRepo.GetAllMembers().FirstOrDefault(m => m.MemberId == member.MemberId);
            if (existingMember != null)
            {
                _membersRepo.AddMember(member);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: MembersController/Edit/5
        public ActionResult Edit(int id)
        {
           _membersRepo.GetMemberById(id);
            return View();
        }

        // POST: MembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Member member)
        {
            _membersRepo.UpdateMember(member);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _membersRepo.DeleteMember(id);
            return RedirectToAction("Index");
        }
    }
}
