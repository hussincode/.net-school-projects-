using Library_Management.Models.Repo.RepoInterface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Library_Management.Models.Repo.RepoClass
{
    public class BookRepo : IBook
    {
        public readonly LibraryContext _context;
        public BookRepo(LibraryContext context)
        {
            _context = context;
        }

        public List<Book> GetBooks()
        {
            var data = _context.Books.ToList();
            return data;
        }

        public Book GetBookById(int id)
        {
            var data = _context.Books.FirstOrDefault(x => x.bookId == id);
            return data;
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            
            _context.Books.Update(book);
            _context.SaveChanges();
        }
        public void DeleteBook(int id)
        {
            var data = _context.Books.FirstOrDefault(x => x.bookId == id);
            if (data != null)
            {
                _context.Books.Remove(data);
                _context.SaveChanges();
            }
        }

    }
}
