using System.ComponentModel.DataAnnotations;

namespace ClassCompassApp.Models;

public class ClassRoom
{
    [Key]
    public int ClassId { get; set; }
    public required string Name { get; set; }
    public required string RoomNumber { get; set; }
    public required string Teacher { get; set; }
    public required string Subject { get; set; }
    public required string GradeLevel { get; set; }
    public required string Schedule { get; set; }
    public string? Notes { get; set; }
    public int Capacity { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}