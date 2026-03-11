using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace practicalSession
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var students = new List<Student>
{
    new Student { Id = 1, Name = "Ahmed Ali", Age = 21, Department = "CS", GPA = 3.6 },
    new Student { Id = 2, Name = "Sara Mohamed", Age = 20, Department = "IT", GPA = 3.2 },
    new Student { Id = 3, Name = "Omar Hassan", Age = 22, Department = "CS", GPA = 2.8 },
    new Student { Id = 4, Name = "Mona Adel", Age = 19, Department = "IS", GPA = 3.9 },
    new Student { Id = 5, Name = "Youssef Kamal", Age = 23, Department = "CS", GPA = 2.4 },
    new Student { Id = 6, Name = "Aya Mostafa", Age = 21, Department = "IT", GPA = 3.5 },
    new Student { Id = 7, Name = "Hassan Mahmoud", Age = 24, Department = "IS", GPA = 1.9 },
    new Student { Id = 8, Name = "Nada Fathy", Age = 20, Department = "CS", GPA = 3.1 },
    new Student { Id = 9, Name = "Ali Samir", Age = 18, Department = "IT", GPA = 2.6 },
    new Student { Id = 10, Name = "Reem Tarek", Age = 22, Department = "IS", GPA = 3.7 },
    new Student { Id = 11, Name = "Amr Nabil", Age = 21, Department = "CS", GPA = 4.0 },
    new Student { Id = 12, Name = "Laila Ashraf", Age = 19, Department = "IT", GPA = 2.2 }
};

            var courses = new List<Course>
 {
     new Course { Id = 1, Title = "C# Fundamentals", Credits = 3 },
     new Course { Id = 2, Title = "OOP", Credits = 4 },
     new Course { Id = 3, Title = "Databases", Credits = 3 },
     new Course { Id = 4, Title = "ASP.NET MVC", Credits = 4 },
     new Course { Id = 5, Title = "LINQ Deep Dive", Credits = 2 }
 };

            var enrollments = new List<Enrollment>
{
    new Enrollment { StudentId = 1, CourseId = 1 },
    new Enrollment { StudentId = 1, CourseId = 2 },

    new Enrollment { StudentId = 2, CourseId = 1 },
    new Enrollment { StudentId = 2, CourseId = 3 },

    new Enrollment { StudentId = 3, CourseId = 2 },

    new Enrollment { StudentId = 4, CourseId = 4 },
    new Enrollment { StudentId = 4, CourseId = 5 },

    new Enrollment { StudentId = 6, CourseId = 3 },
    new Enrollment { StudentId = 6, CourseId = 4 },

    new Enrollment { StudentId = 8, CourseId = 1 },

    new Enrollment { StudentId = 10, CourseId = 2 },
    new Enrollment { StudentId = 10, CourseId = 3 },

    new Enrollment { StudentId = 11, CourseId = 5 }
};

            //Warm-up 
            var StudenName = students.Select(s => s.Name).ToList();
            Console.WriteLine("Students Name:");

            foreach (var item in StudenName)
            {
                Console.WriteLine(item);
            }

            var anonymousobjectfromstudent = students.Select(s => new { name = s.Name, GPA = s.GPA });

            Console.WriteLine("anonymous object from student:");
            foreach (var item in anonymousobjectfromstudent)
            {
                Console.WriteLine(item);
            }

            var checkifstudenthavemorethan38inGPA = students.Where(s => s.GPA > 3.8);

            Console.WriteLine("check if student have more than 3.8 in GPA");
            foreach (var item in checkifstudenthavemorethan38inGPA)
            {
                Console.WriteLine($"{item.Name} - {item.Age} - {item.Department} - {item.GPA}");
            }

            var Checkifallstudentsareolderthan18 = students.Where(s => s.Age > 18);
            Console.WriteLine("Check if all students are older than 18:");

            foreach (var item in Checkifallstudentsareolderthan18)
            {
                Console.WriteLine($"{item.Name} - {item.Age} - {item.Department}");
            }

            var Getstudentswhoseageisgreaterthan20 = students.Where(s => s.Age > 20);
            Console.WriteLine("Check if all students are older than 20:");

            foreach (var item in Getstudentswhoseageisgreaterthan20)
            {
                Console.WriteLine($"{item.Name} - {item.Age} - {item.Department}");
            }

            var csStudents = students
    .Where(s => s.Department == "CS")
    .ToList();

            Console.WriteLine("Students in CS department:");

            foreach (var student in csStudents)
            {
                Console.WriteLine($"{student.Name} - {student.GPA}");
            }

            var SelectNameandDepartmentforallstudents = students.Select(s => new { name = s.Name, Department = s.Department });
            Console.WriteLine("Select Name and Department for all students:");
            foreach (var item in SelectNameandDepartmentforallstudents)
            {
                Console.WriteLine($"{item.name} - {item.Department}");
            }

            var OrderstudentsbyGPAascending = students.OrderBy(s => s.GPA).ToList();
            Console.WriteLine("Order students by GPA ascending:");

            foreach (var item in OrderstudentsbyGPAascending)
            {
                Console.WriteLine($"{item.Name} - {item.GPA}");
            }


            var OrderstudentsbyGPAdescendingthenNameascending = students.OrderByDescending(s => s.GPA).ThenBy(s => s.Name);

            Console.WriteLine("Order students by GPA descending then Name ascending:");
            foreach (var item in OrderstudentsbyGPAdescendingthenNameascending)
            {
                Console.WriteLine($"{item.Name} - {item.GPA}");
            }


            var Getthetop5studentsbyGPA = students.OrderByDescending(s => s.GPA).Take(5);
            Console.WriteLine("Get the top 5 students by GPA:");
            foreach (var item in Getthetop5studentsbyGPA)
            {
                Console.WriteLine($"{item.Name} - {item.GPA}");
            }


            var CheckifanystudenthasGPAlessthan20 = students.Any(s => s.GPA < 2.0);
            Console.WriteLine("Check if any student has GPA less than 2.0:");
            Console.WriteLine(CheckifanystudenthasGPAlessthan20);
            
            var CheckifallstudentshaveGPA = students.All(s => s.GPA >= 2.0);
            Console.WriteLine("Check if all students have GPA greater than or equal to 2.0:");
            Console.WriteLine(CheckifallstudentshaveGPA);

            var Counttotalnumberofstudents = students.Count();

            Console.WriteLine("Count total number of students:");
            Console.WriteLine(Counttotalnumberofstudents);
            

        }
    }
}
