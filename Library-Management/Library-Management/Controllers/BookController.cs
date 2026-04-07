using Library_Management.Models;
using Library_Management.Models.Repo.RepoInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library_Management.Controllers
{
    public class BookController : Controller
    {
        public readonly IBook _book;
        public BookController (IBook book)
        {
            this._book = book;
        }
        public IActionResult Index()
        {
            var data = _book.GetBooks();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            var data = new Book
            {
                author = book.author,
                title = book.title,
                AvailableCopies = book.AvailableCopies

            };
            _book.AddBook(data);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _book.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book book)
        {

            if (!ModelState.IsValid)
            {
                return View(book);
            }

            var existingBook = _book.GetBookById(book.bookId);
            if (existingBook == null)
            {
                return NotFound();
            }

            _book.UpdateBook(book);
            return RedirectToAction("Index");


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var book = _book.GetBookById(id);
            if(book != null)
            {
                _book.DeleteBook(id);
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }

}
