using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSessionone.Models
{
    internal class DBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Profile> Profiles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)// This method is used to configure the model and its relationships using the Fluent API.
        {
            modelBuilder.Entity<Student>().
                HasOne(s => s.department).WithMany(d => d.Student).HasForeignKey(s => s.DepartmentId);

            modelBuilder.Entity<Student>().
                HasOne(s => s.profile)
                .WithOne(p => p.student)
                .HasForeignKey<Profile>(p=>p.StudentId);

            modelBuilder.Entity<Course>()
                .HasMany(s => s.students)
                .WithMany(p => p.courses);
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  // This method is used to configure the database connection and other options for the DbContext.
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\Husseinhesham;Initial Catalog=TestMigration;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
