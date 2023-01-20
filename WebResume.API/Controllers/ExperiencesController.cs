using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.AspNetCore.Mvc;
using WebResume.API.Dtos;
using WebResume.API.Models;

namespace WebResume.API.Controllers
{
    [ApiController]
    [Route("api/experiences")]
    public class ExperiencesController : ControllerBase
    {

        [HttpGet]
        public async Task<IEnumerable<Experience>> GetExperiences()
        {
            IAmazonDynamoDB dynamoDbClient = new AmazonDynamoDBClient();
            DynamoDBContext _dynamoDBContext = new DynamoDBContext(dynamoDbClient);
            return await _dynamoDBContext.ScanAsync<Experience>(new List<ScanCondition>()).GetRemainingAsync();
        }

        [HttpGet("{id}")]
        public ActionResult<ExperienceDto> GetExperienceById(Guid id) 
        {
            var result = ExperienceDataStore.Instance.Experiences.FirstOrDefault(x => x.ExperienceId == id);
            if(result== null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
