namespace WebResume.API.Models
{
    public class ProjectDto
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public string TechnologyStack { get; set; }
        public string ShortDescription { get; set; } = string.Empty;
        public string DetailedDescription { get; set; } = string.Empty;
        public int MaxTeamSize { get; set; }
        public string Role { get; set; }
        public int Order { get; set; }
        public List<string> Responsibilites { get; set; } = new List<string>();
    }
}
