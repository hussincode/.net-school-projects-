namespace Library_Management.Models.Repo.RepoInterface
{
    public interface IMember
    {
        public List<Member> GetMembers();
        public Member GetMemberById(int id);
        public void AddMember(Member member);
        public void UpdateMember(Member member);
        public void DeleteMember(int id);
    }
}
