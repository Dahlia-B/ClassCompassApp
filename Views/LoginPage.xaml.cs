using ClassCompassApp.Views;

namespace ClassCompassApp.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnTeacherLoginClicked(object sender, EventArgs e)
    {
        // Get the service from DI container
        var teacherLoginPage = Application.Current?.Handler?.MauiContext?.Services
            .GetService<TeacherLoginPage>();

        if (teacherLoginPage != null)
        {
            await Navigation.PushAsync(teacherLoginPage);
        }
    }

    private async void OnStudentLoginClicked(object sender, EventArgs e)
    {
        // Get the service from DI container
        var studentLoginPage = Application.Current?.Handler?.MauiContext?.Services
            .GetService<StudentLoginPage>();

        if (studentLoginPage != null)
        {
            await Navigation.PushAsync(studentLoginPage);
        }
    }
}