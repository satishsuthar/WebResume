
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.EntityFrameworkCore;
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
    public class ExperienceRepository : BaseRepository<Experience>, IExperienceRepository
    {
        public ExperienceRepository(IAmazonDynamoDB dynamoDbClient) : base(dynamoDbClient)
        {
        }
    }
}
