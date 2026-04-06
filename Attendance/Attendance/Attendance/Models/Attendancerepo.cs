using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;
using System.Runtime.InteropServices.JavaScript;

namespace Attendance.Models
{
    public class Attendancerepo : IAttendance
    {
        public readonly Attendancecontext c;
        public Attendancerepo(Attendancecontext contexr)
        {
            c = contexr;
                
         }

        public List<Attendancem> GetAll()
        {
            return c.Attendances.Include(a => a.Student).Include(b => b.Subject).ToList();
        }

    

        public void Delete(Attendancem attendancem)
        {
            c.Remove(attendancem);

        }

        public void UPDATE(Attendancem attendancem)
        {
            var ex = c.FirstOrDefault(o => o.AttendanceId == attendancem.AttendanceId);
            if (ex != null)
            {
                ex.Student = attendancem.Student;
                ex.Status = attendancem.Status;
                ex.Subject = attendancem.Subject;
                ex.date = attendancem.date;

            }
        }

        public Attendancem GetById(int id)
        {
            return c.Attendances.Include(a => a.Student).Include(b => b.Subject).FirstOrDefault(a => a.AttendanceId == id);

        }

        public void ADD(VM a)
        {
            var data = new Attendancem
            {
                SubjectId = a.SubjectId,
                StudentId = a.StudentId,
                Status = a.Status,
                date = a.date,
            };
            c.Attendances.Add(data);
            c.SaveChanges();

        }
    }
}
