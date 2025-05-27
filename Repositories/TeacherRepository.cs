using ClassCompassApp.Data;
using ClassCompassApp.Models;
using ClassCompassApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassCompassApp.Repositories
{
    public class TeacherRepository
    {
        private readonly AppDbContext _dbContext;

        public TeacherRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
