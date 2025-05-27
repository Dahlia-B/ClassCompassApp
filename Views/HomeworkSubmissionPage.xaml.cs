using ClassCompassApp.Models;
using ClassCompassApp.Services;
using ClassCompassApp.Data;
using Microsoft.Maui.Controls;

namespace ClassCompassApp.Views
{
    public partial class HomeworkSubmissionPage : ContentPage
    {
        private string SelectedFileURL = "https://example.com/dummyfile.pdf";
        private readonly HomeworkApi _homeworkApi;

        public HomeworkSubmissionPage(HomeworkApi homeworkApi)
        {
            InitializeComponent();
            _homeworkApi = homeworkApi;
        }

        private async void OnChooseFileClicked(object sender, EventArgs e)
        {
            // TODO: Use FilePicker to get URL
            SelectedFileURL = "https://example.com/dummyfile.pdf";
            await DisplayAlert("File Selected", "Mock file selected!", "OK");
        }

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            // Assuming App.CurrentUser is a string user ID
            var currentUserId = App.CurrentUser;
            if (string.IsNullOrWhiteSpace(currentUserId))
            {
                await DisplayAlert("Error", "No current user found.", "OK");
                return;
            }

            var submission = new HomeworkSubmission
            {
                HomeworkId = HomeworkIdEntry.Text,
                StudentId = currentUserId, // Use string directly
                FileURL = SelectedFileURL
            };

            var result = await _homeworkApi.SubmitHomework(submission);

            if (result)
            {
                await DisplayAlert("Success", "Homework submitted successfully!", "OK");
            }
            else
            {
                await DisplayAlert("Error", "Failed to submit homework.", "OK");
            }
        }
    }
}