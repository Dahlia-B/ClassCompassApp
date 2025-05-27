using ClassCompassApp.Views;

namespace ClassCompassApp.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // ✅ Updated navigation using Shell.Current
    private async void OnSchoolSignUpClicked(object sender, EventArgs e)
    {
        await NavigateToAsync(nameof(SchoolSignUpPage));
    }

    private async void OnTeacherSignUpClicked(object sender, EventArgs e)
    {
        await NavigateToAsync(nameof(TeacherSignUpPage));
    }

    private async void OnStudentSignUpClicked(object sender, EventArgs e)
    {
        await NavigateToAsync(nameof(StudentSignUpPage));
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await NavigateToAsync(nameof(LoginPage));
    }

    // ✅ Centralized navigation method with error handling
    private async Task NavigateToAsync(string route)
    {
        try
        {
            await Shell.Current.GoToAsync(route);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Navigation Error", $"Failed to navigate: {ex.Message}", "OK");
        }
    }
}
