using System.ComponentModel.DataAnnotations;

namespace Library_Management.Models
{
    public class Book
    {
        [Key]
        public int bookId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int AvailableCopies { get; set; }
    }
}
