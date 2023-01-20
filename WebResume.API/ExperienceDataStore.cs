using WebResume.API.Dtos;

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
                    Designation = "Associate",
                    Projects = new List<ProjectDto>()
                    {
                        new ProjectDto()
                        {
                            ProjectId= new Guid("D2C8830E-BF2C-428A-94AF-5FE362118AAE"),
                            Name = "Cartus",
                            ShortDescription = "Project for worlds leading logistic company",
                            DetailedDescription = "This project automates relocation process for a customer. It helps retrieve all the related policies and generates a report.",
                            MaxTeamSize= 8,
                            Order= 100,
                            Role = "Associate",
                            TechnologyStack = "Microsoft Visual Studio .NET 2000, ASP. NET, C#, Microsoft SQL Server",
                            Responsibilites = new List<string>()
                            {
                                "Fixing defects as a part of production-support team",
                                "Coding for different enhancements for the application"
                            }
                        },
                        new ProjectDto()
                        {
                            ProjectId= new Guid("6FCD552A-D1B9-47A1-B258-69FC7C482880"),
                            Name = "Confidential",
                            ShortDescription = "This is a project for a client that has a chain of hospitals in USA",
                            DetailedDescription = "The project is basically taking care of communication among various levels of management.",
                            MaxTeamSize= 3,
                            Order= 110,
                            Role = "Associate",
                            TechnologyStack = "Microsoft Visual Studio .NET 2000, ASP. NET, C#, Microsoft SQL Server",
                            Responsibilites = new List<string>()
                            {
                                "Development of Workflow module Version 2",
                                "Coding and Testing the Application."
                            }
                        },
                        new ProjectDto()
                        {
                            ProjectId= new Guid("35546080-FF5B-460D-8E78-66600F40A060"),
                            Name = "Misys",
                            ShortDescription = "Windows based clinic management application",
                            DetailedDescription = "This project records all the tests that the patient has undergone. It takes care of billing, clinical activities, mail, storing records etc.",
                            MaxTeamSize= 8,
                            Order= 120,
                            Role = "Associate",
                            TechnologyStack = "Microsoft Visual Studio .NET 2000, ASP. NET, C#, Microsoft SQL Server",
                            Responsibilites = new List<string>()
                            {
                                "Understanding the entire Architecture of application with 67 Layers in no time.",
                                "Coding for different enhancements in the application"
                            }
                        }
                    }
                },
                new ExperienceDto()
                {
                    ExperienceId = new Guid("897F3138-C792-4CD9-BFC1-CBBB016B950A"),
                    Company = "Sumeru Software",
                    StartDate = new DateTime(2007,2,26),
                    EndDate= new DateTime(2014,10,31),
                    Designation = "Solutions Architect",
                    Projects = new List<ProjectDto>()
                    {
                        new ProjectDto()
                        {
                            ProjectId= new Guid("D2C8830E-BF2C-428A-94AF-5FE362118AAE"),
                            Name = "MiCash",
                            ShortDescription = "Project for worlds leading logistic company",
                            DetailedDescription = "This project automates relocation process for a customer. It helps retrieve all the related policies and generates a report.",
                            MaxTeamSize= 8,
                            Order= 200,
                            Role = "Associate",
                            TechnologyStack = "ASP.Net, C#, JavaScript",
                            Responsibilites = new List<string>()
                            {
                                "Interfacing the system with two banks (Design and Development both) using XML format for dynamic form saving",
                                "Implementing SOAP call for one bank"
                            }
                        },
                        new ProjectDto()
                        {
                            ProjectId= new Guid("6FCD552A-D1B9-47A1-B258-69FC7C482880"),
                            Name = "StatsOnline",
                            ShortDescription = "Project for worlds leading logistic company",
                            DetailedDescription = "This project automates relocation process for a customer. It helps retrieve all the related policies and generates a report.",
                            MaxTeamSize= 8,
                            Order= 210,
                            Role = "Associate",
                            TechnologyStack = "Microsoft Visual Studio .NET 2000, ASP. NET, C#, Microsoft SQL Server",
                            Responsibilites = new List<string>()
                            {
                                "Leading Team of 5 members on technology front.",
                                "Migrating from ColdFusion to .Net environment without prior knowledge of legacy system.",
                                "Generating complex Dynamic reports",
                                "During the migration supporting and fixing issues on ColdFusion."
                            }
                        },
                        new ProjectDto()
                        {
                            ProjectId= new Guid("35546080-FF5B-460D-8E78-66600F40A060"),
                            Name = "Frieght Space",
                            ShortDescription = "Project for worlds leading logistic company",
                            DetailedDescription = "This project automates relocation process for a customer. It helps retrieve all the related policies and generates a report.",
                            MaxTeamSize= 8,
                            Order= 220,
                            Role = "Associate",
                            TechnologyStack = "Microsoft Visual Studio .NET 2000, ASP. NET, C#, Microsoft SQL Server",
                            Responsibilites = new List<string>()
                            {
                                "Fixing defects as a part of production-support team",
                                "Coding for different enhancements for the application"
                            }
                        }
                    }
                }
            };
        }
    }
}
