using Library_Management.Models.Repo.RepoInterface;
using Microsoft.EntityFrameworkCore;

namespace Library_Management.Models.Repo.RepoClass
{
    public class BorrowRepo : IBorrow
    {
        public readonly LibraryContext _context;
        public BorrowRepo(LibraryContext context)
        {
            this._context = context;
        }
        public List<Borrow> GetBorrows()
        {
            return _context.Borrows.ToList();
        }

        public Borrow GetBorrowById(int id)
        {
            return _context.Borrows.Find(id);
        }

        public void AddBorrow(Borrow borrow)
        {
            _context.Borrows.Add(borrow);
            _context.SaveChanges();
        }

        public void UpdateBorrow(Borrow borrow)
        {
            _context.Borrows.Update(borrow);
            _context.SaveChanges();
        }

        public List<Borrow> FilterRecords(string search)
        {
            return _context.Borrows
                .Include(b => b.Book)
                .Include(b => b.Member)
                .Where(b => b.Member != null && b.Book != null &&
                            (b.Member.name.Contains(search) || b.Book.title.Contains(search)))
                .ToList();
        }

        public void DeleteBorrow(int id)
        {
            var borrow = _context.Borrows.Find(id);
            if (borrow != null)
            {
                _context.Borrows.Remove(borrow);
                _context.SaveChanges();
            }
        }
    }
}
