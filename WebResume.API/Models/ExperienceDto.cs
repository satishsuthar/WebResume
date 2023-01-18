namespace WebResume.API.Models
{
    public class ExperienceDto
    {
        public Guid ExperienceId { get; set; }
        public string Company { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Designation { get; set; } = string.Empty;

    }
}
