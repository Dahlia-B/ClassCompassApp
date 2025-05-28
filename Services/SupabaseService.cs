using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

public class SupabaseService
{
    private readonly HttpClient _httpClient;

    public SupabaseService()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://<your-project>.supabase.co/rest/v1/")
        };

        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", "<your-service-role-key>");
    }

    public async Task<string> GetStudentsAsync()
    {
        var response = await _httpClient.GetAsync("students");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}
