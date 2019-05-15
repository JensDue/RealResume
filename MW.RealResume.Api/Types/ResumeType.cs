using GraphQL.Types;
using MW.RealResume.DataAccess;
using MW.RealResume.Model;

namespace MW.RealResume.Api.Types
{
    public class ResumeType : ObjectGraphType<Resume>
    {
        public ResumeType(Repository data)
        {
            Name = "Resume";

            Field(h => h.Id).Description("The id of the resume.");
            Field(h => h.Name, true).Description("The name of the resume.");
            Field(h => h.Timestamp).Description("Last edited timestamp.");
            Field(h => h.Email);

            Field<ListGraphType<CompanyType>>("companies", resolve: context => data.GetCompanies());
            Field<ListGraphType<EducationType>>("educations", resolve: context => data.GetEducations());
            Field<ListGraphType<SkillType>>("skills", resolve: context => data.GetSkills());
            Field<ListGraphType<ProjectType>>("projects", resolve: context => data.GetProjects());
        }
    }
}