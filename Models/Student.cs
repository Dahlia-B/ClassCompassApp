using SQLite;
using System.ComponentModel.DataAnnotations.Schema;
using ClassCompassApp.Models;

[SQLite.Table("Students")]
public class Student
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public int StudentId { get; set; }  // External student number

    public string PasswordHash { get; set; } = string.Empty;
    public string ClassName { get; set; } = string.Empty;
    public int TeacherId { get; set; }
    public int ClassId { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public bool IsActive { get; set; } = true;
    public bool NotificationsEnabled { get; set; } = true;

    [Ignore]
    public List<Grade> Grades { get; set; } = new();

    [Ignore]
    public List<BehaviorRemark> BehaviorRemarks { get; set; } = new();

    [Ignore]
    public double OverallAverage => Grades.Any() ? Grades.Average(g => g.Percentage) : 0;
}
