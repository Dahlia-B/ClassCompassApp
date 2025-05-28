using SQLite;
using ClassCompassApp.Models; // Adjust namespace as needed

namespace ClassCompassApp.Services
{
    public class DatabaseService
    {
        private SQLiteAsyncConnection? _database; // Made nullable to fix warning
        
        public async Task InitializeAsync()
        {
            if (_database != null)
                return;
                
            var databasePath = DatabasePath.GetDatabasePath();
            
            // Ensure directory exists with null check
            var directory = Path.GetDirectoryName(databasePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                Directory.CreateDirectory(directory);
                
            _database = new SQLiteAsyncConnection(databasePath);
            
            // Create tables
            await _database.CreateTableAsync<User>();
            // Add other tables as needed
        }
        
        // Add your database methods here
        public async Task<int> SaveUserAsync(User user)
        {
            await InitializeAsync();
            if (_database == null) throw new InvalidOperationException("Database not initialized");
            return await _database.InsertAsync(user);
        }
        
        public async Task<User> GetUserAsync(int id)
        {
            await InitializeAsync();
            if (_database == null) throw new InvalidOperationException("Database not initialized");
            return await _database.GetAsync<User>(id);
        }
        
        // Add other CRUD methods...
    }
}