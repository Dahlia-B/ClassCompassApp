using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

[SQLite.Table("Teachers")]
public class Teacher
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int TeacherId { get; set; }
    public string PasswordHash { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public int SchoolId { get; set; }
    public bool IsActive { get; set; } = true;

    [Ignore]
    public List<string> Subjects
    {
        get => Subject.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();
        set => Subject = string.Join(",", value.Distinct());
    }

    [Ignore]
    public List<Student> Students { get; set; } = new();
}
