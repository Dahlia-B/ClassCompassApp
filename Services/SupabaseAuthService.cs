using System.Threading.Tasks;
using ClassCompassAPI.Data.Models;

namespace ClassCompassAPI.Services
{
    public class SupabaseAuthService
    {
        public Task<User?> AuthenticateUser(string name, string password)
        {
            // Implement actual authentication logic here
            return Task.FromResult<User?>(null);
        }
    }
}