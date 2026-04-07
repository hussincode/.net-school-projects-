namespace Library_Management.Models.Repo.RepoInterface
{
    public interface IBorrow
    {
        List<Borrow> GetBorrows();
        Borrow GetBorrowById(int id);
        void AddBorrow(Borrow borrow);
        void UpdateBorrow(Borrow borrow);
        List<Borrow> FilterRecords(string search);
        void DeleteBorrow(int id);
    }
}
