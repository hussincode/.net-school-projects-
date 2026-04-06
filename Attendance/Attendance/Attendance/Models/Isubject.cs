namespace Attendance.Models
{
    public interface Isubject
    {
        List<Subject> GetAll();
        void ADD(Subject subject);
        void DELETE(Subject subject);
        void Update(Subject subject);
        Subject GetById(int id);
    }
}
