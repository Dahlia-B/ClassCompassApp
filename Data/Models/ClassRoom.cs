using System.ComponentModel.DataAnnotations;
using ClassCompassApp.Data;

public class ClassRoom
{
    [Key]
    public int Id { get; set; }

    public int ClassId { get; set; }

    public string Class { get; set; } = string.Empty;

    [Required]
    public string RoomNumber { get; set; } = string.Empty;

    [Required]
    public string Subject { get; set; } = string.Empty;

    [Required]
    public string Schedule { get; set; } = string.Empty; // e.g., "Mon-Wed 10:00-11:30"

    public string? Notes { get; set; }

    public int Capacity { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;

    // FK and navigation property to School
    public int SchoolId { get; set; }
    public School School { get; set; } = null!;

    public ICollection<Student> Students { get; set; } = new List<Student>();

    public ICollection<Attendance> AttendanceRecords { get; set; } = new List<Attendance>();

    public ICollection<HomeworkSubmission> HomeworkSubmissions { get; set; } = new List<HomeworkSubmission>();

    public ICollection<Grade> Grades { get; set; } = new List<Grade>();

    // FK and navigation to Teacher (optional)
    public int? TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
}