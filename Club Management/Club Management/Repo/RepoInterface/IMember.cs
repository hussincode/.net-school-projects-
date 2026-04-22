using Club_Management.Models;

namespace Club_Management.Repo.RepoInterface
{
    public interface IMember
    {
        public List<Member> GetAllMembers();
        public Member GetMemberById(int id);
        public void AddMember(Member member);
        public void UpdateMember(Member member);    
        public void DeleteMember(int id);

    }
}
