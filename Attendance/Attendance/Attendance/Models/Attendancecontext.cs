using Microsoft.EntityFrameworkCore;

namespace Attendance.Models
{
    public class Attendancecontext : DbContext
    {
        public Attendancecontext(DbContextOptions<Attendancecontext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
                .Property(a => a.date)
                .HasConversion(
                    d => d.ToDateTime(TimeOnly.MinValue),   // Save as DateTime
                    d => DateOnly.FromDateTime(d)          // Read back as DateOnly
                );
        }


    }
}
