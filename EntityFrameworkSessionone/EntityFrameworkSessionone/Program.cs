using EntityFrameworkSessionone.Models;

namespace EntityFrameworkSessionone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBContext context = new DBContext();
            Department department = new Department { Name = "Computer Science" };
            context.Add(department);
            context.SaveChanges();
        }
    }
}
