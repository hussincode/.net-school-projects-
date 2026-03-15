using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSessionone.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Bio { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
    }
}
