using System.ComponentModel.DataAnnotations;

namespace ClassCompassApp.Data;

public class School
{
    [Key]
    public int SchoolId { get; set; }

    public string Name { get; set; } = string.Empty;

    public int NumberOfClasses { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public ICollection<ClassRoom> Classes { get; set; } = new List<ClassRoom>();

    public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
