using ClassCompassApp.Data;
using ClassCompassApp.Views;
using ClassCompassApp.Services;
using CommunityToolkit.Maui;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ClassCompassApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Get the proper database path for the device
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "classcompass.db");

            // Register SQLite EF Core DbContext with proper path
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite($"Data Source={databasePath}"));

            // Register API services for DI
            builder.Services.AddScoped<AttendanceApi>();
            builder.Services.AddScoped<GradesApi>();
            builder.Services.AddScoped<HomeworkApi>();

            // Register user session service as singleton
            builder.Services.AddSingleton<UserSessionService>();

            // Register pages for dependency injection
            builder.Services.AddTransient<TeacherLoginPage>();
            builder.Services.AddTransient<TeacherDashboard>();
            builder.Services.AddTransient<StudentLoginPage>();
            builder.Services.AddTransient<StudentDashboard>();
            builder.Services.AddTransient<TeacherSignUpPage>();
            builder.Services.AddTransient<StudentSignUpPage>();
            builder.Services.AddTransient<SchoolSignUpPage>();
            builder.Services.AddTransient<AttendanceTrackingPage>();
            builder.Services.AddTransient<HomeworkSubmissionPage>();
            builder.Services.AddTransient<TeacherGradingPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}