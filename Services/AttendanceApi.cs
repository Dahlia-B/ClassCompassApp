using ClassCompassApp.Data;

public class AttendanceApi
{
    private readonly AppDbContext _context;

    public AttendanceApi(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> MarkAttendance(Attendance record)
    {
        try
        {
            _context.Attendances.Add(record);
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
}