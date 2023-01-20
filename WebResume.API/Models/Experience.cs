using Amazon.DynamoDBv2.DataModel;

namespace WebResume.API.Models
{
    [DynamoDBTable("Experiences")]
    public class Experience
    {
        [DynamoDBHashKey]
        public Guid Id { get; set; }
        [DynamoDBRangeKey]
        public string Name { get; set; } = string.Empty;


    }
}
