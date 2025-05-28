using Microsoft.Maui.Storage;

namespace ClassCompassApp.Services
{
    public static class DatabasePath
    {
        public static string GetDatabasePath()
        {
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "classcompass.db");
            return databasePath;
        }
    }
}