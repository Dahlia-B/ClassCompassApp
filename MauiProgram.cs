using ClassCompassApp.Data;
using ClassCompassApp.Views;
using ClassCompassApp.Services; // <-- Add this if your API services are in Services namespace
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

            // Register SQLite EF Core DbContext (Scoped lifetime)
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=classcompass.db"));

            // Register API services for DI (Scoped or Transient as appropriate)
            builder.Services.AddScoped<AttendanceApi>();
            builder.Services.AddScoped<GradesApi>();
            builder.Services.AddScoped<HomeworkApi>();

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