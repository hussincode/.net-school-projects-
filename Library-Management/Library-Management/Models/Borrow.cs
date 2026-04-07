using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace Library_Management.Models
{
    public class Borrow
    {
        [Key]
        public int borrowId { get; set; }
        public DateOnly borrowdate { get; set; }
        public DateOnly? returndate { get; set; }
        public string status { get; set; }
        [ForeignKey("Book")]
        public int bookId { get; set; }
        public Book Book { get; set; }
        [ForeignKey("Member")]
        public int memberId { get; set; }
        public Member Member { get; set; }
    }
}
