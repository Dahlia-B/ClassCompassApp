using Supabase;
using Supabase.Storage;
using System.IO;
using System.Threading.Tasks;

namespace ClassCompassAPI.Services
{
    public class SupabaseStorageHelper
    {
        private readonly Supabase.Client _client;

        public SupabaseStorageHelper(string url, string anonKey)
        {
            _client = new Supabase.Client(url, anonKey);
            _client.InitializeAsync().Wait();
        }

        public async Task<string> UploadFileAsync(Stream fileStream, string fileName)
        {
            var storage = _client.Storage.From("homework-submissions");

            // Convert Stream to byte[]
            using var ms = new MemoryStream();
            await fileStream.CopyToAsync(ms);
            var bytes = ms.ToArray();

            var response = await storage.Upload(fileName, bytes, "application/octet-stream");
            // Get the public URL to the file
            var publicUrl = storage.GetPublicUrl(fileName);
            return publicUrl;
        }
    }
}