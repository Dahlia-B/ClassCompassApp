using Microsoft.EntityFrameworkCore;
using ClassCompassApp.Models;

namespace ClassCompassApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<HomeworkSubmission> HomeworkSubmissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<School>().HasKey(s => s.SchoolId);
            modelBuilder.Entity<Attendance>().HasKey(a => a.AttendanceId);

            // Add additional model configuration here if needed
        }
    }
}
