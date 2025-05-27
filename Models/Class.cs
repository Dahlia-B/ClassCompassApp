using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassCompassApp.Models
{
    [SQLite.Table("Classes")]
    public class Class
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ClassId { get; set; } // External class identifier
        public int TeacherId { get; set; }
        public int SchoolId { get; set; }
        public string Grade { get; set; } = string.Empty; // Grade level
        public int MaxStudents { get; set; } = 30;
        public bool IsActive { get; set; } = true;

        [Ignore]
        public List<Student> Students { get; set; } = new();

        [Ignore]
        public int CurrentEnrollment => Students.Count(s => s.IsActive);
    }
}