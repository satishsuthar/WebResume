using Microsoft.AspNetCore.Mvc;
using WebResume.API.Dtos;
using WebResume.Application.Contracts.Persistence;

namespace WebResume.API.Controllers
{
    //Since project is aggregate child and it's root is experience. As per DDD, the DDD is the only member of the AGGREGATE that outside
    //objects are allowed to hold reference. So all projects should only be accessed via experience object.
    public class ProjectsController
    {

        
    }
}
