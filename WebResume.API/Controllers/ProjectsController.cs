using Microsoft.AspNetCore.Mvc;
using WebResume.API.Dtos;
using WebResume.API.Models;

namespace WebResume.API.Controllers
{
    [Route("/api/experiences/{experienceId}/projects")]    
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProjectDto>> GetProjects(Guid experienceId)
        {
            var experience = ExperienceDataStore.Instance.Experiences.FirstOrDefault(x => x.ExperienceId == experienceId);
            if(experience == null)
            {
                return NotFound();
            }
            return Ok(experience.Projects);
        }
        [HttpGet("{projectId}")]
        public ActionResult<ProjectDto> GetProject(Guid experienceId, Guid projectId) 
        {
            var experience = ExperienceDataStore.Instance.Experiences.FirstOrDefault(x => x.ExperienceId == experienceId);
            if (experience == null)
            {
                return NotFound();
            }
            var project = experience.Projects.FirstOrDefault(p => p.ProjectId == projectId);
            if(project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }
    }
}
