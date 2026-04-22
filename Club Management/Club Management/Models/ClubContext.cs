using Microsoft.EntityFrameworkCore;

namespace Club_Management.Models
{
    public class ClubContext : DbContext
    {
        public ClubContext(DbContextOptions<ClubContext> options) : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<ActivityModel> Activities { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}
