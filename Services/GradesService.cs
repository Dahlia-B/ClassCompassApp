using ClassCompassAPI.Data;
using ClassCompassAPI.Models;

namespace ClassCompassAPI.Services
{
    public class GradesService
    {
        private readonly ClassCompassDbContext _context;

        public GradesService(ClassCompassDbContext context)
        {
            _context = context;
        }

    }
}