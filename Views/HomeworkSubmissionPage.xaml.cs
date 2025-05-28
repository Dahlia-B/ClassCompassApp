using ClassCompassApp.Models; // Make sure this is the correct namespace
using ClassCompassApp.Services;
using Microsoft.Maui.Controls;

namespace ClassCompassApp.Views
{
    public partial class HomeworkSubmissionPage : ContentPage
    {
        private string SelectedFileURL = string.Empty;
        private readonly HomeworkApi _homeworkApi;

        public HomeworkSubmissionPage(HomeworkApi homeworkApi)
        {
            InitializeComponent();
            _homeworkApi = homeworkApi;
        }

        private async void OnChooseFileClicked(object sender, EventArgs e)
        {
            // TODO: Implement actual file picker here, for now mock URL:
            SelectedFileURL = "https://example.com/dummyfile.pdf";
            await DisplayAlert("File Selected", "Mock file selected!", "OK");
        }

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            // Validate user logged in
            var currentUser = App.CurrentUser as User;  // Cast App.CurrentUser to User class
            if (currentUser == null)
            {
                await DisplayAlert("Error", "No current user found.", "OK");
                return;
            }

            var currentUserId = currentUser.UserId;  // Access UserId property of the User class

            if (string.IsNullOrWhiteSpace(currentUserId))
            {
                await DisplayAlert("Error", "User ID is empty.", "OK");
                return;
            }

            // Validate HomeworkId is numeric
            if (string.IsNullOrEmpty(HomeworkIdEntry.Text) || !int.TryParse(HomeworkIdEntry.Text, out int homeworkId))
            {
                await DisplayAlert("Error", "Please enter a valid numeric Homework ID.", "OK");
                return;
            }

            if (string.IsNullOrEmpty(SelectedFileURL))
            {
                await DisplayAlert("Error", "Please choose a file before submitting.", "OK");
                return;
            }

            var submission = new HomeworkSubmission
            {
                HomeworkId = homeworkId,
                StudentId = int.Parse(currentUserId), // Assuming UserId is a string, parse it to int
                FileURL = SelectedFileURL
            };

            var result = await _homeworkApi.SubmitHomework(submission);

            if (result)
            {
                await DisplayAlert("Success", "Homework submitted successfully!", "OK");
                HomeworkIdEntry.Text = string.Empty;
                SelectedFileURL = string.Empty;
            }
            else
            {
                await DisplayAlert("Error", "Failed to submit homework.", "OK");
            }
        }
    }
}
