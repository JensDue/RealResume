using GraphQL.Types;
using MW.RealResume.Api;
using MW.RealResume.DataAccess;
using MW.RealResume.Model;

namespace MW.RealResume.Api.Types
{
    public class ProjectType : ObjectGraphType<Project>
    {
        public ProjectType(Repository data)
        {
            Name = "Project";

            Field(h => h.Id).Description("The id of the Project*.");
            Field(h => h.Name, nullable: true).Description("The name of the Project.");
            Field(h => h.Timestamp).Description("Last edited timestamp.");
            Field(h => h.Location);
            Field(h => h.Description);
            Field(h => h.StartDate);
            Field(h => h.EndDate);

            //Interface<ProjectInterface>();
        }
    }
}
