using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebResume.API.Services;

namespace WebResume.API.Controllers
{
    [Route("api/resume")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private readonly IConfiguration _config;
        public ResumeController(IConfiguration config)
        {
            _config = config;
        }
        [HttpGet]
        public async Task<ActionResult> GetFile()
        {
            AWSCoreService _awsService = new AWSCoreService(_config);
            string fileName = "personal/public/Satish Suthar CV SA.docx";

            //var sessionToken = "";
            var bucketName = "my-random-assets";
            SessionAWSCredentials tempCredentials = await _awsService.GetTemporaryCredentialsAsync();
            IAmazonS3 _awsS3Client = new AmazonS3Client(tempCredentials, Amazon.RegionEndpoint.APSoutheast2);
            GetObjectRequest getObjectRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = fileName
            };
            MemoryStream ms = null;
            using (var response = await _awsS3Client.GetObjectAsync(getObjectRequest))
            {
                if (response.HttpStatusCode == HttpStatusCode.OK)
                {
                    using (ms = new MemoryStream())
                    {
                        await response.ResponseStream.CopyToAsync(ms);
                    }
                }
            }

            if (ms is null || ms.ToArray().Length < 1)
                return NotFound();
            else
                return File(ms.ToArray(), "application/octet-stream", fileName);

        }



    }
}
