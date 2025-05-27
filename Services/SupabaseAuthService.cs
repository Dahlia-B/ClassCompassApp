using Supabase;
using System.Threading.Tasks;

namespace ClassCompassAPI.Services
{
    public class SupabaseAuthService
    {
        private readonly Supabase.Client _client;

        public SupabaseAuthService(string url, string anonKey)
        {
            _client = new Supabase.Client(url, anonKey);
            _client.InitializeAsync().Wait();
        }

        public async Task<User> SignUpAsync(string email, string password)
        {
            var response = await _client.Auth.SignUp(email, password);
            return response.User;
        }

        public async Task<User> SignInAsync(string email, string password)
        {
            var response = await _client.Auth.SignIn(email, password);
            return response.User;
        }

        public async Task SignOutAsync()
        {
            await _client.Auth.SignOut();
        }
    }
}