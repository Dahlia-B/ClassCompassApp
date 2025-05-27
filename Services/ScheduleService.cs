using ClassCompassAPI.Data;
using ClassCompassAPI.Models;

namespace ClassCompassAPI.Services
{
    public class ScheduleService
    {
        private readonly ClassCompassDbContext _context;

        public ScheduleService(ClassCompassDbContext context)
        {
            _context = context;
        }

    }
}