using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace Attendance.Models
{
    public class SubjecRepo : Isubject
    {
        public readonly List<Subject> _subject;
        public SubjecRepo()
        {
            _subject = new List<Subject>();
        }

        public List<Subject> GetAll()
        {
            return _subject;
        }

        public void ADD(Subject subject)
        {
            _subject.Add(subject);
        }

        public void Update(Subject subject)
        {
            var ex = _subject.FirstOrDefault(s =>  s.SubjectId == subject.SubjectId);
            if (ex != null)
            {
                ex.Name = subject.Name;
                
            }
        }

        public void DELETE(Subject subject)
        {
            _subject.Remove(subject);
        }

        public Subject GetById(int id)
        {
            return _subject.FirstOrDefault(s => s.SubjectId == id);
        }

         
    }
}
