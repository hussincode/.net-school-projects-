using Hotel_Management_System.Models;
using Hotel_Management_System.Models.VM;
using Hotel_Management_System.Repo.RepoInterface;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Management_System.Repo.RepoClass
{
    public class BookingRecordRepo : IBookingRecords
    {
        private readonly HotelContext _context;

        public BookingRecordRepo(HotelContext context)
        {
            _context = context;
        }

        public List<BookingRecordsVM> GetAll()
        {
            return _context.bookingRecords
                           .Include(b => b.Room)
                           .Select(b => new BookingRecordsVM
                           {
                               BookingRecordId = b.BookingRecordId,
                               CheckInDate = b.CheckInDate,
                               CheckOutDate = b.CheckOutDate,
                               TotalPrice = b.TotalPrice,
                               Notes = b.Notes,
                               RoomId = b.RoomId,
                               BookingRecords = new List<BookingRecord> { b }
                           })
                           .ToList();
        }

        public BookingRecordsVM GetById(int id)
        {
            var b = _context.bookingRecords
                            .Include(br => br.Room)
                            .FirstOrDefault(br => br.BookingRecordId == id);

            if (b == null) return null;

            return new BookingRecordsVM
            {
                BookingRecordId = b.BookingRecordId,
                CheckInDate = b.CheckInDate,
                CheckOutDate = b.CheckOutDate,
                TotalPrice = b.TotalPrice,
                Notes = b.Notes,
                RoomId = b.RoomId,
                BookingRecords = new List<BookingRecord> { b }
            };
        }

        public void Add(BookingRecordsVM record)
        {
            var entity = new BookingRecord
            {
                CheckInDate = record.CheckInDate,
                CheckOutDate = record.CheckOutDate,
                TotalPrice = record.TotalPrice,
                Notes = record.Notes,
                RoomId = record.RoomId
            };

            _context.bookingRecords.Add(entity);
            _context.SaveChanges();
        }

        public void Update(BookingRecordsVM record)
        {
            var entity = _context.bookingRecords.Find(record.BookingRecordId);
            if (entity != null)
            {
                entity.CheckInDate = record.CheckInDate;
                entity.CheckOutDate = record.CheckOutDate;
                entity.TotalPrice = record.TotalPrice;
                entity.Notes = record.Notes;
                entity.RoomId = record.RoomId;

                _context.bookingRecords.Update(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var entity = _context.bookingRecords.Find(id);
            if (entity != null)
            {
                _context.bookingRecords.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
