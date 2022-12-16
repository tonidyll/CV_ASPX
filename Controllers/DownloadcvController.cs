using Microsoft.AspNetCore.Mvc;
namespace P1_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadcvController : ControllerBase
    {
        private readonly IWebHostEnvironment environment;
        public DownloadcvController(IWebHostEnvironment hostEnvironment)
        {
            environment = hostEnvironment;
        }
        [HttpGet("download")]
        public IActionResult Download()
        {
            var filepath = Path.Combine(environment.WebRootPath, "images", "cv.pdf");
            return File(System.IO.File.ReadAllBytes(filepath), "files/pdf", System.IO.Path.GetFileName(filepath));
        }
    }
}