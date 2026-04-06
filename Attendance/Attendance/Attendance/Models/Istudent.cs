namespace Attendance.Models
{
    public interface Istudent
    {
        List<Student>  GetAll();
        void ADD(Student student);
        void DELETE(Student student);
        void Update (Student student);
        Student GetById(int id);
        
    }
}
