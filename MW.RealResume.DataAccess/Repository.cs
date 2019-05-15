using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MW.RealResume.Model;

namespace MW.RealResume.DataAccess
{
    public class Repository
    {
        private readonly List<Company> _companies = new List<Company>();
        private readonly List<Education> _educations = new List<Education>();
        private readonly List<Project> _projects = new List<Project>();
        private readonly Resume _resume;

        private readonly StaticData _staticData;


        public Repository(StaticData staticData)
        {

            _staticData = staticData;

            _companies.Add(
                new Company
                {
                    Id = 0,
                    Name = "KMD",
                    Timestamp = new DateTime(2019, 4, 1, 11, 55, 00),                        
                    Industry = "Information technology", //TODO: Implement as Enum
                    Headquarters = "Ballerup",
                    Website = "kmd.dk",
                    Description = "KMD er blandt Danmarks største it- og softwarevirksomheder med afdelinger i København, Århus, Odense og Aalborg.",                   
                });

            //TODO: Add more example data
            _educations.Add(
                new Education
                {
                    Id = 0,
                    Name = "Mat/Fys Student",
                    Timestamp = new DateTime(2019, 4, 1, 11, 55, 01),
                    School = "Åbenrå Gymnasium",
                    Degree = "Student",                    
                    StartDate = new DateTime(1993, 8, 1),
                    EndDate = new DateTime(1995, 7, 1),
                }
            );

            //TODO: Add more example data
            _projects.Add(
                new Project
                {
                    Id = 0,
                    Name = "Rave Booking System",
                    Timestamp = new DateTime(2019, 4, 1, 11, 55, 02),
                    Description = "This a short description of the project",
                    Location = "Berlin",
                    StartDate = new DateTime(2015, 4, 1, 11, 55, 02),
                    EndDate = new DateTime(2019, 4, 1, 11, 55, 02),
                }
            );

            _projects.Add(
                new Project
                {
                    Id = 1,
                    Name = "Deal Capture System",
                    Timestamp = new DateTime(2019, 4, 2, 11, 55, 05),
                    Description = "This a short description of the project",
                    Location = "London",
                    StartDate = new DateTime(2010, 4, 1, 11, 55, 02),
                    EndDate = new DateTime(2015, 4, 1, 11, 55, 02),
                }
            );

            _resume = new Resume
            {
                Id = 101,
                Name = "Jens Tue Bolsen",
                Timestamp = new DateTime(2019, 4, 3, 11, 55, 08),
                Email = "tue.bolsen@gmail.com",
                Companies = _companies,
                Educations = _educations,
                Projects = _projects,
                Skills = _staticData.Skills,
            };
        }
    
        public Task<Company> GetCompanyByIdAsync(int id)
        {
            return Task.FromResult(_companies.FirstOrDefault(h => h.Id == id));
        }

        public IEnumerable<Company> GetCompanies()
        {
            return _companies.AsEnumerable();
        }

        public Task<Education> GetEducationByIdAsync(int id)
        {
            return Task.FromResult(_educations.FirstOrDefault(h => h.Id == id));
        }

        public IEnumerable<Education> GetEducations()
        {
            return _educations.AsEnumerable();
        }

        public IEnumerable<Project> GetProjects()
        {
            return _projects.AsEnumerable();
        }

        public Task<Project> GetProjectByIdAsync(int id)
        {
            return Task.FromResult(_projects.FirstOrDefault(h => h.Id == id));
        }

        public Resume GetResume()
        {
            return _resume;
        }

        public IEnumerable<Skill> GetSkills()
        {
            return _staticData.Skills.AsEnumerable();
        }

        public Skill GetSkillByIdAsync(int id)
        {
            return _staticData.Skills.FirstOrDefault(h => h.Id == id);
        }
    }
}
