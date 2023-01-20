using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DataModel;
namespace WebResume.Domain.Entities
{
    [DynamoDBTable("Experiences")]
    public class Experience
    {
        [DynamoDBHashKey]
        public Guid Id { get; set; }
        [DynamoDBRangeKey]
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Designation { get; set; } = string.Empty;
        public ICollection<Project> Projects { get; set; }
    }
}
