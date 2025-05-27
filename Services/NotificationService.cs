using System.Text;

public class NotificationService
{
    private readonly HttpClient _httpClient;

    public NotificationService()
    {
        _httpClient = new HttpClient();
    }

    public async Task SendClassReminder(string userId)
    {
        var notification = new
        {
            to = userId,
            notification = new
            {
                title = "Class Reminder",
                body = "Your class starts in 5 minutes!"
            }
        };

        var jsonContent = JsonConvert.SerializeObject(notification);
        var response = await _httpClient.PostAsync("https://fcm.googleapis.com/fcm/send",
            new StringContent(jsonContent, Encoding.UTF8, "application/json"));

        Console.WriteLine($"Notification sent: {response.StatusCode}");
    }
}
