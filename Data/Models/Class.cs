using ClassCompassApp.Data;

using SQLite;

[Table("Classes")]
public class Class
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int ExternalClassCode { get; set; }

    public int TeacherId { get; set; }

    public int SchoolId { get; set; }

    public string Grade { get; set; } = string.Empty;

    public int MaxStudents { get; set; } = 30;

    public bool IsActive { get; set; } = true;

    [Ignore]
    public List<Student> Students { get; set; } = new();

    [Ignore]
    public int CurrentEnrollment => Students.Count(s => s.IsActive);
}
