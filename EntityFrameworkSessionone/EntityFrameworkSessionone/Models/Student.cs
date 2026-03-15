using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSessionone.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MinLength(8)] 
        
        public string Name { get; set; }


        public Profile profile { get; set; }

        public int DepartmentId { get; set; }

        public Department department { get; set; }
        public List<Course> courses { get; set; }

    }
}
