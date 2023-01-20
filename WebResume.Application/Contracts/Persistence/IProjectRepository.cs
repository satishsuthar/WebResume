using WebResume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebResume.Application.Contracts.Persistence
{
    public interface IProjectRepository : IAsyncRepository<Project>
    {
    }
}
