using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebResume.Domain.Entities;

namespace WebResume.Application.Contracts.Persistence
{
    public interface IExperienceRepository : IAsyncRepository<Experience>
    {
    }
}
