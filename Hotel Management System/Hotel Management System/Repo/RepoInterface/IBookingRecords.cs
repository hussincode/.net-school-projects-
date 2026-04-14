using Hotel_Management_System.Models.VM;

namespace Hotel_Management_System.Repo.RepoInterface
{
    public interface IBookingRecords
    {
        public List<BookingRecordsVM> GetAll();
        public BookingRecordsVM GetById(int id);
        public void Add(BookingRecordsVM record);
        public void Update(BookingRecordsVM record);
        public void Delete(int id);

    }
}
