
using ClassCompassApp.Models;
using ClassCompassApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ClassCompassApp.Services;

public class HomeworkApi
{
    private readonly AppDbContext _context;

    public HomeworkApi(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> SubmitHomework(HomeworkSubmission submission)
    {
        try
        {
            _context.HomeworkSubmissions.Add(submission);
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
