using Microsoft.AspNetCore.Mvc;
using WebResume.API.Models;

namespace WebResume.API.Controllers
{
    [ApiController]
    [Route("api/expereiences")]
    public class ExperiencesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ExperienceDto>> GetExperiences()
        {
            return Ok(ExperienceDataStore.Instance.Experiences);
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
