namespace Library_Management.Models.Repo.RepoInterface
{
    public interface IBook
    {
        public List<Book> GetBooks();
        public Book GetBookById(int id);
        public void AddBook(Book book);
        public void UpdateBook(Book book);
        public void DeleteBook(int id);
    }
}
