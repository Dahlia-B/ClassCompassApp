using ClassCompassApp.Views;

namespace ClassCompassApp;

public partial class App : Application
{
    public static string? CurrentUser { get; set; }
    public static string? UserRole { get; set; }

    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}