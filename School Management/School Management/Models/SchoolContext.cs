using Microsoft.EntityFrameworkCore;
using System.Data.Common;
namespace School_Management.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> option) : base(option)
        { 
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
