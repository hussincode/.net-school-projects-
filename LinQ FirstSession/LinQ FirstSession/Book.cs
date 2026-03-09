using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_FirstSession
{
    internal class Book
    {
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public int Page { get; set; }
        
        public virtual void Tostring()
        {
            Console.WriteLine($"Title: {Title}, AuthorID: {AuthorID}, Page: {Page}");
        }
    }
}
