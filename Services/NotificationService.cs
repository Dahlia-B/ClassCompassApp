using System.Threading.Tasks;

namespace ClassCompassApp.Services
{
    public static class NotificationService
    {
        public static async Task SendClassReminder(string userId)
        {
            // Replace with actual Firebase call logic
            await Task.Delay(500); // Simulate network delay
            System.Diagnostics.Debug.WriteLine($"Class reminder sent to {userId}");
        }
    }
}
