using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class ApiService
{
    private readonly HttpClient _client = new HttpClient();

    public async Task<List<Student>?> GetStudentsAsync()
    {
        var url = "http://localhost:5169/api/students";
        return await _client.GetFromJsonAsync<List<Student>>(url);
    }


}
