using ClassCompassAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClassCompassAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StorageController : ControllerBase
    {
        private readonly SupabaseStorageHelper _supabaseHelper;

        public StorageController(SupabaseStorageHelper supabaseHelper)
        {
            _supabaseHelper = supabaseHelper;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile([FromQuery] string localPath, [FromQuery] string objectName)
        {
            await _supabaseHelper.UploadFileAsync(localPath, objectName);
            return Ok($"Uploaded {objectName}");
        }

        [HttpGet("download")]
        public async Task<IActionResult> DownloadFile([FromQuery] string objectName, [FromQuery] string localPath)
        {
            await _supabaseHelper.DownloadFileAsync(objectName, localPath);
            return Ok($"Downloaded {objectName} to {localPath}");
        }
    }
}