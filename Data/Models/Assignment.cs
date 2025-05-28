using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassCompassApp.Data
{
    [SQLite.Table("Assignments")]
    public class Assignment
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public DateTime DateCreated { get; set; }
        public double MaxScore { get; set; }
        public bool IsActive { get; set; } = true;

        [Ignore]
        public string FormattedDueDate => DueDate.ToString("MMM dd, yyyy 'at' h:mm tt");

        [Ignore]
        public bool IsOverdue => DateTime.Now > DueDate && IsActive;
    }

}