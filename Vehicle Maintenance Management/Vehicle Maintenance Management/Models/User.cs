using System.ComponentModel.DataAnnotations;

namespace Vehicle_Maintenance_Management.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public List< Vehicle> vehicles { get; set; }
    }
}
