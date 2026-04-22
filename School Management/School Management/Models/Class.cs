namespace School_Management.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public DateOnly ScheduleDate { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Student> Students { get; set; }

    }
}
