namespace ClassCompass.Constants
{
    public static class AppConstants
    {
        public const string APP_NAME = "ClassCompass";
        public const string DATABASE_NAME = "classcompass.db";

        // User Types
        public const string USER_TYPE_TEACHER = "Teacher";
        public const string USER_TYPE_STUDENT = "Student";

        // Default schedule times
        public static readonly TimeSpan[] DEFAULT_CLASS_TIMES =
        {
            new TimeSpan(8, 0, 0),   // 8:00 AM
            new TimeSpan(9, 0, 0),   // 9:00 AM
            new TimeSpan(10, 0, 0),  // 10:00 AM
            new TimeSpan(11, 0, 0),  // 11:00 AM
            new TimeSpan(13, 0, 0),  // 1:00 PM
            new TimeSpan(14, 0, 0),  // 2:00 PM
            new TimeSpan(15, 0, 0),  // 3:00 PM
        };

        public const int DEFAULT_CLASS_DURATION = 45; // minutes
    }
}