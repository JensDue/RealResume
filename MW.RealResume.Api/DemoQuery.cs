using System;
using GraphQL.Types;
using MW.RealResume.Api.Types;
using MW.RealResume.DataAccess;

namespace MW.RealResume.Api
{
    public class DemoQuery : ObjectGraphType<object>
    {
        public DemoQuery(Repository data)
        {
            Name = "Query";

            Field<CompanyType>("company", arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                        {Name = "id", Description = "id"}
                ),
                resolve: context => data.GetCompanyByIdAsync(context.GetArgument<string>("id"))
            );

            Field<ProjectType>("project", arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                        {Name = "id", Description = "id of the project"}
                ),
                resolve: context => data.GetProjectByIdAsync(context.GetArgument<string>("id"))
            );

            Field<EducationType>("education", arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                        {Name = "id", Description = "id of the education"}
                ),
                resolve: context => data.GetEducationByIdAsync(context.GetArgument<string>("id"))
            );

            Field<SkillType>("skill", arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                        {Name = "id", Description = "id of the skill"}
                ),
                resolve: context => data.GetSkillByIdAsync(context.GetArgument<string>("id"))
            );

            Field<ResumeType>("resume", resolve: context => data.GetResume());

            Field<ListGraphType<CompanyType>>("companies", resolve: context => data.GetCompanies());
            Field<ListGraphType<EducationType>>("educations", resolve: context => data.GetEducations());
            Field<ListGraphType<ProjectType>>("projects", resolve: context => data.GetProjects());
            Field<ListGraphType<SkillType>>("skills", resolve: context => data.GetSkills());
        }
    }
}
