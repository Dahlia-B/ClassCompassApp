using System.ComponentModel.DataAnnotations;

namespace ClassCompassApp.Models;

public class School
{
    [Key]
    public required string SchoolId { get; set; }
    public required string Name { get; set; }
    public int NumberOfClasses { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}