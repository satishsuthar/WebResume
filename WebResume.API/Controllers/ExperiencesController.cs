using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.AspNetCore.Mvc;
using WebResume.API.Dtos;
using WebResume.Application.Contracts.Persistence;
using WebResume.Domain.Entities;
namespace WebResume.API.Controllers
{
    [ApiController]
    [Route("api/experiences")]
    public class ExperiencesController : ControllerBase
    {
        private readonly IExperienceRepository _experienceRepository;
        public ExperiencesController(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Experience>>> GetExperiences()
        {

            return Ok(await _experienceRepository.ListAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Experience>> GetExperienceById(Guid id) 
        {
            var result = await _experienceRepository.GetByIdAsync(id);
            if (result== null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
