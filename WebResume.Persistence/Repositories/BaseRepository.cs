using WebResume.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;

namespace WebResume.Persistence.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        public readonly DynamoDBContext _context;
        public BaseRepository(IAmazonDynamoDB dynamoDbClient)
        {
            _context = new DynamoDBContext(dynamoDbClient);
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _context.LoadAsync<T>(id);
        }

        public async  Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _context.ScanAsync<T>(new List<ScanCondition>()).GetRemainingAsync();
        }


    }
}
