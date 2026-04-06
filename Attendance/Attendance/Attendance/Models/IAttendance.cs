namespace Attendance.Models
{
    public interface IAttendance
    {
        List<Attendancem> GetAll();
        void ADD(VM a);
        void Delete(Attendancem attendancem);
        void UPDATE(Attendancem attendancem);
        Attendancem  GetById(int id);



    }
}
