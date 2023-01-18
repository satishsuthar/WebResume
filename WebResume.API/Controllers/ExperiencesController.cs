using Microsoft.AspNetCore.Mvc;

namespace WebResume.API.Controllers
{
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        [HttpGet("api/expereiences")]
        public JsonResult GetExperiences()
        {
            return new JsonResult(ExperienceDataStore.Instance.Experiences);
        }
    }
}
