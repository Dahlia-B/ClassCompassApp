using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class StorageController : ControllerBase
{
    private readonly FirebaseStorageHelper _firebaseHelper;

    public StorageController()
    {
        string bucketName = "your-project-id.appspot.com";  // replace with your bucket
        _firebaseHelper = new FirebaseStorageHelper("your-project-id", bucketName);
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadFile([FromQuery] string localPath, [FromQuery] string objectName)
    {
        await _firebaseHelper.UploadFileAsync(localPath, objectName);
        return Ok($"Uploaded {objectName}");
    }

    [HttpGet("download")]
    public async Task<IActionResult> DownloadFile([FromQuery] string objectName, [FromQuery] string localPath)
    {
        await _firebaseHelper.DownloadFileAsync(objectName, localPath);
        return Ok($"Downloaded {objectName} to {localPath}");
    }
}
