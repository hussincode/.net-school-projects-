using Microsoft.EntityFrameworkCore;

namespace Clinc_Mang.Models
{
    public class APPDBcontext : DbContext
    {
        
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .HasMany(d => d.Appointment)
                .WithOne(a => a.Doctors)
                .HasForeignKey(a => a.DoctorsId);
            modelBuilder.Entity<Patient>()
                .HasMany(p => p.Appointment)
                .WithOne(a => a.Patients)
                .HasForeignKey(a => a.PatientsId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\Husseinhesham;Initial Catalog=Clinc;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
