using Microsoft.EntityFrameworkCore;

namespace Cinema.Models
{
    public class Cinemacontext : DbContext
    {
        public Cinemacontext(DbContextOptions<Cinemacontext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Showtime> Showtimes { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
