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
                    Id = "0",
                    Name = "KMD",
                    Timestamp = new DateTime(2019, 4, 1, 11, 55, 00),                        
                    Industry = "Information technology", //TODO: Implement as Enum
                    Headquarters = "Ballerup",
                    Website = "kmd.dk",
                    Description = "KMD er blandt Danmarks st�rste it- og softwarevirksomheder med afdelinger i K�benhavn, �rhus, Odense og Aalborg.",                   
                });

            //TODO: Add more example data
            _educations.Add(
                new Education
                {
                    Id = "0",
                    Name = "Mat/Fys Student",
                    Timestamp = new DateTime(2019, 4, 1, 11, 55, 01),
                    School = "�benr� Gymnasium",
                    Degree = "Student",
                    StartDate = new DateTime(1993, 8, 1),
                    EndDate = new DateTime(1995, 7, 1),
                }
            );

            //TODO: Add more example data
            _projects.Add(
                new Project
                {
                    Id = "0",
                    Name = "Bl.a.",
                    Timestamp = new DateTime(2019, 4, 1, 11, 55, 02),                                      
                }
            );

            _projects.Add(
                new Project
                {
                    Id = "1",
                    Name = "KJsjdfh kjsh fkjhsfkj hskjf hskdhf ks hfd",
                    Timestamp = new DateTime(2019, 4, 2, 11, 55, 05),
                }
            );

            _projects.Add(
                new Project
                {
                    Id = "2",
                    Name = "Isdkfj. Khkjfdhwehfkjhf sdkfj: Jen sfh kj",
                    Timestamp = new DateTime(2019, 4, 3, 11, 55, 08),
                }
            );

            _resume = new Resume
            {
                Id = "101",
                Name = "Jens Tue Bolsen",
                Timestamp = new DateTime(2019, 4, 3, 11, 55, 08),
                Email = "tue.bolsen@gmail.com",
                Companies = _companies,
                Educations = _educations,
                Projects = _projects,
                Skills = _staticData.Skills,
            };
        }
    
        public Task<Company> GetCompanyByIdAsync(string id)
        {
            return Task.FromResult(_companies.FirstOrDefault(h => h.Id == id));
        }

        public IEnumerable<Company> GetCompanies()
        {
            return _companies.AsEnumerable();
        }

        public Task<Education> GetEducationByIdAsync(string id)
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

        public Task<Project> GetProjectByIdAsync(string id)
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

        public Skill GetSkillByIdAsync(string id)
        {
            return _staticData.Skills.FirstOrDefault(h => h.Id == id);
        }
    }
}
