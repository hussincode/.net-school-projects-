using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSessionone.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public List<Student> Student { get; set; }

    }
}
