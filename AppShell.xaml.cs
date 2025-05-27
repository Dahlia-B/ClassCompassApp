using ClassCompassApp.Views;  
using Microsoft.Maui.Controls;

namespace ClassCompassApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(SchoolSignUpPage), typeof(SchoolSignUpPage));
            Routing.RegisterRoute(nameof(TeacherSignUpPage), typeof(TeacherSignUpPage));
            Routing.RegisterRoute(nameof(StudentSignUpPage), typeof(StudentSignUpPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(TeacherLoginPage), typeof(TeacherLoginPage));
            Routing.RegisterRoute(nameof(StudentLoginPage), typeof(StudentLoginPage));
            Routing.RegisterRoute(nameof(StudentDashboard), typeof(StudentDashboard));
            Routing.RegisterRoute(nameof(TeacherDashboard), typeof(TeacherDashboard));
        }
    }
}
