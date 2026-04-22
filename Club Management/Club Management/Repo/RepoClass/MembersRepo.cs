using Club_Management.Models;
using Club_Management.Repo.RepoInterface;

namespace Club_Management.Repo.RepoClass
{
    public class MembersRepo : IMember
    {
        public readonly ClubContext _context;
        public MembersRepo(ClubContext context)
        {
            _context = context;
        }
        public Member GetMemberById(int id)
        {
            return _context.Members.FirstOrDefault(m => m.MemberId == id);
        }
        public List<Member> GetAllMembers()
        {
            return _context.Members.ToList();
        }
        public void AddMember(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
        }
        public void UpdateMember(Member member)
        {
            _context.Members.Update(member);
            _context.SaveChanges();
        }
        public void DeleteMember(int id)
        {
            var member = _context.Members.FirstOrDefault(m => m.MemberId == id);
            if (member != null)
            {
                _context.Members.Remove(member);
                _context.SaveChanges();
            }
        }
    }
}
