using Microsoft.AspNetCore.Mvc;

namespace WebResume.API.Controllers
{
    [ApiController]
    [Route("api/expereiences")]
    public class ExperiencesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetExperiences()
        {
            return new JsonResult(ExperienceDataStore.Instance.Experiences);
        }

        [HttpGet("{id}")]
        public JsonResult GetExperienceById(Guid id) 
        {
            return new JsonResult(ExperienceDataStore.Instance.Experiences.FirstOrDefault(x => x.ExperienceId == id));
        }
    }
}
