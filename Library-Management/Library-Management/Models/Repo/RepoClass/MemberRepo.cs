using Library_Management.Models.Repo.RepoInterface;

namespace Library_Management.Models.Repo.RepoClass
{
    public class MemberRepo : IMember
    {
        public readonly LibraryContext _context;
        public MemberRepo(LibraryContext context)
        {
            _context = context;
        }

        public List<Member> GetMembers()
        {
            var data = _context.Members.ToList();
            return data;
        }

        public Member GetMemberById(int id)
        {
            var data = _context.Members.FirstOrDefault(x => x.memberId == id);
            return data;
        }

        public void AddMember(Member Member)
        {
            _context.Members.Add(Member);
            _context.SaveChanges();
        }

        public void UpdateMember(Member Member)
        {
            _context.Members.Update(Member);
            _context.SaveChanges();
        }

        public void DeleteMember(int id)
        {
            var data = _context.Members.FirstOrDefault(x => x.memberId == id);
            if (data != null)
            {
                _context.Members.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
