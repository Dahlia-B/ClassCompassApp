using ClassCompassApp.Models;
using ClassCompassApp.Services;
using ClassCompassApp.Data;
using Microsoft.Maui.Controls;

namespace ClassCompassApp.Views
{
    public partial class TeacherGradingPage : ContentPage
    {
        private readonly GradesApi _gradesApi;

        public TeacherGradingPage(AppDbContext dbContext)
        {
            InitializeComponent();
            _gradesApi = new GradesApi(dbContext);
        }

        private async void OnSubmitGradeClicked(object sender, EventArgs e)
        {
            if (!int.TryParse(ScoreEntry.Text, out int score))
            {
                await DisplayAlert("Error", "Please enter a valid numeric score.", "OK");
                return;
            }

            string studentId = StudentIdEntry.Text;

            var result = await _gradesApi.AssignGrade(studentId, score);

            if (result)
            {
                await DisplayAlert("Success", "Grade submitted successfully!", "OK");
            }
            else
            {
                await DisplayAlert("Error", "Failed to submit grade.", "OK");
            }
        }
    }
}