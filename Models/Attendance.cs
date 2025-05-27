using System.ComponentModel.DataAnnotations;

namespace ClassCompassApp.Models;

public class Attendance
{
    public required string AttendanceId { get; set; }
    public required string StudentId { get; set; }
    public required string Status { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string? Notes { get; set; }
}