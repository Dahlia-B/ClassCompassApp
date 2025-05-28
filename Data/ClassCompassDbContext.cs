using ClassCompassAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassCompassAPI.Data
{
    public class ClassCompassDbContext : DbContext
    {
        public ClassCompassDbContext(DbContextOptions<ClassCompassDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Assignment> Assignments { get; set; } // Instead of unnamed DbSet
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your models here
            base.OnModelCreating(modelBuilder);
        }
    }
}