using Microsoft.EntityFrameworkCore;

namespace Hotel_Management_System.Models
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Room> rooms { get; set; }
        public DbSet<User> users { get;set; }
        public DbSet<ServiceType> serviceTypes { get; set; }
        public DbSet<BookingRecord> bookingRecords { get; set; }

    }
}
