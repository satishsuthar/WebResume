using WebResume.API.Models;

namespace WebResume.API
{
    public class ExperienceDataStore
    {
        public List<ExperienceDto> Experiences { get; set; }
        public static ExperienceDataStore Instance { get; } = new ExperienceDataStore();
        public ExperienceDataStore() 
        {
            Experiences = new List<ExperienceDto>()
            {
                new ExperienceDto()
                {
                    ExperienceId = new Guid("FDFCAE6C-09DD-4307-9404-3C87857AF44C"),
                    Company = "Perot Systems",
                    StartDate = new DateTime(2005,7,18),
                    EndDate= new DateTime(2007,2,19),
                    Designation = "Associate"
                },
                new ExperienceDto()
                {
                    ExperienceId = new Guid("897F3138-C792-4CD9-BFC1-CBBB016B950A"),
                    Company = "Sumeru Software",
                    StartDate = new DateTime(2007,2,26),
                    EndDate= new DateTime(2014,10,31),
                    Designation = "Solutions Architect"
                }
            };
        }
    }
}
