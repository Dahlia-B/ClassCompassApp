using ClassCompassApp.Models;
using ClassCompassApp.Services;
using ClassCompassApp.Data;

namespace ClassCompassApp.Views;

public partial class AttendanceTrackingPage : ContentPage
{
    private readonly AttendanceApi _attendanceApi;

    public AttendanceTrackingPage(AppDbContext dbContext)
    {
        InitializeComponent();
        _attendanceApi = new AttendanceApi(dbContext);
    }

    private async void OnSubmitAttendanceClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(StudentIdEntry.Text))
        {
            await DisplayAlert("Error", "Please enter a Student ID", "OK");
            return;
        }

        if (StatusPicker.SelectedItem == null)
        {
            await DisplayAlert("Error", "Please select a status", "OK");
            return;
        }

        var record = new Attendance
        {
            AttendanceId = Guid.NewGuid().ToString(),
            StudentId = StudentIdEntry.Text,
            Status = StatusPicker.SelectedItem.ToString()
        };

        try
        {
            var result = await _attendanceApi.MarkAttendance(record);
            if (result)
            {
                await DisplayAlert("Success", "Attendance recorded successfully!", "OK");
                StudentIdEntry.Text = string.Empty;
                StatusPicker.SelectedIndex = -1;
            }
            else
            {
                await DisplayAlert("Error", "Failed to record attendance.", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Failed to record attendance: {ex.Message}", "OK");
        }
    }
}