public class Attendance
{
    public required string AttendanceId { get; set; }

    public required int StudentId { get; set; }
    public required string Status { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;

    public string? Notes { get; set; }

    public int ClassRoomId { get; set; }

    public ClassRoom ClassRoom { get; set; } = null!;

    public Student Student { get; set; } = null!;

    public bool Present { get; set; }
}
