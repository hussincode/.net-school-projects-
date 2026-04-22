namespace School_Management.Models.VM
{
    public class ClassesVM
    {
        public int ClassId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public DateOnly ScheduleDate { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int UserId { get; set; }
        public List<User> Users { get; set; }
    }
}
