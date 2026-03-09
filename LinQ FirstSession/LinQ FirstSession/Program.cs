using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ_FirstSession
{
   

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Athoer> athoers = new List<Athoer>()
            {
                new Athoer { ID = 1, Name = "Author1" },
                new Athoer { ID = 2, Name = "Author2" },
                new Athoer { ID = 3, Name = "Author3" }
            };

            List<Book> books = new List<Book>()
            {
                new Book { Title = "Book1", AuthorID = 1, Page = 100 },
                new Book { Title = "Book2", AuthorID = 2, Page = 200 },
                new Book { Title = "Book3", AuthorID = 1, Page = 150 },
                new Book { Title = "Book4", AuthorID = 3, Page = 300 }
            };

            // JOIN
            var joinQuery =
                from book in books
                join author in athoers
                on book.AuthorID equals author.ID
                select new { book.Title, author.Name };

            Console.WriteLine("Join Result:");
            foreach (var item in joinQuery)
            {
                Console.WriteLine(item.Title + " - " + item.Name);
            }

            // WHERE
            var whereQuery = books.Where(b => b.AuthorID == 1);

            Console.WriteLine("\nBooks of Author 1:");
            foreach (var book in whereQuery)
            {
                Console.WriteLine(book.Title);
            }

            // FIRST
            var firstBook = books.First(b => b.AuthorID == 1);
            Console.WriteLine("\nFirst Book of Author1: " + firstBook.Title);

            // ORDER
            var ordered = books.OrderBy(b => b.Page);

            Console.WriteLine("\nBooks Ordered By Pages:");
            foreach (var book in ordered)
            {
                Console.WriteLine(book.Title + " - " + book.Page);
            }

            // ANY
            bool any = books.Any(b => b.Page > 250);
            Console.WriteLine("\nIs there book with pages > 250 ? " + any);

            // ALL
            bool all = books.All(b => b.Page > 50);
            Console.WriteLine("\nAre all books have pages > 50 ? " + all);

            //contains
            var contains = books.Any(b => b.Title.Contains("B"));
            Console.WriteLine("\nIs there book with 'B' in title ? " + contains);

            //aggregation functions
            var totalPages = books.Sum(b => b.Page);
            Console.WriteLine("\nTotal Pages of all books: " + totalPages);
            var averagePages = books.Average(b => b.Page);
            Console.WriteLine("\nAverage Pages of all books: " + averagePages);
            var maxPages = books.Max(b => b.Page);
            Console.WriteLine("\nMax Pages of all books: " + maxPages);
            var minPages = books.Min(b => b.Page);
            Console.WriteLine("\nMin Pages of all books: " + minPages);
            //count
            var count = books.Count();
            Console.WriteLine("\nTotal number of books: " + count);

        }
    }
}