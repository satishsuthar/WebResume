using Amazon.Runtime;
using Amazon.SecurityToken.Model;
using Amazon.SecurityToken;

namespace WebResume.API.Services
{
    public class AWSCoreService
    {
        private readonly IConfiguration _config;

        public AWSCoreService(IConfiguration config)
        {
            _config = config;
        }
        public async Task<SessionAWSCredentials> GetTemporaryCredentialsAsync()
        {
            var s3Credential = _config.GetSection("ResumeS3ReadonlyCredentials").Get<S3ReadonlyCredentials>(); 
            using (var stsClient = new AmazonSecurityTokenServiceClient(s3Credential.AccessKey, s3Credential.Secret))
            {
                var getSessionTokenRequest = new GetSessionTokenRequest
                {
                    DurationSeconds = 900 // seconds
                };

                GetSessionTokenResponse sessionTokenResponse =
                              await stsClient.GetSessionTokenAsync(getSessionTokenRequest);

                Credentials credentials = sessionTokenResponse.Credentials;

                var sessionCredentials =
                    new SessionAWSCredentials(credentials.AccessKeyId,
                                              credentials.SecretAccessKey,
                                              credentials.SessionToken);
                return sessionCredentials;
            }
        }
    }
}
