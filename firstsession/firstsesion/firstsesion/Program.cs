using firstsesion;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;

namespace firstses0tion
{
    internal class Program 
    {   

        delegate bool delegate1(book book);
        static int Hh(List<book> books, delegate1 d)
        {
            int cont = 0;
            foreach (var book in books)
            {
                if (d(book))
                {
                    cont++;
                }
            }
            return cont;
        }

        static bool START(book books) => books.des.StartsWith("A");
        static bool end(book books) => books.name.EndsWith("c");
        public static void print200(List<book> books)
        {
            int count = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].price <= 200)
                {
                    Console.WriteLine("The Number of book > 200");
                    count++;
                    Console.WriteLine(count);
                }

            }
        }
        
        static void Main(string[] args)
        {
            List<book> list = new List<book>()
            {
                new book ("rich dad", 100, "make you rich"),
                new book ("bad dad", 200, "make you bad dady"),
                new book ("good dad", 900, "Aake you good dadc")
            };

            int count = 0;

            book b = new book("Aich dad", 100, "Aake you ricc");

            delegate1 with = START;
            Console.WriteLine(Hh(list, with));
            Console.WriteLine(Hh(list, (book b) => b.des.EndsWith("c")));

            var x = new
            {
                name = "hussin",
                age = 99
                
            };







        }
    }
}