using Amazon.DynamoDBv2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebResume.Application.Contracts.Persistence;
using WebResume.Domain.Entities;
using WebResume.Persistence.Repositories;

namespace WebResume.Persistence.Repositories
{
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        public ProjectRepository(IAmazonDynamoDB dynamoDbClient) : base(dynamoDbClient)
        {
        }

    }
}
