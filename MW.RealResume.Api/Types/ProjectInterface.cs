using GraphQL.Types;
using MW.RealResume.Model;

namespace MW.RealResume.Api.Types
{
    public class ProjectInterface : InterfaceGraphType<Project>
    {
        public ProjectInterface()
        {
            Name = "Project";

            Field(d => d.Id).Description("The id of the Project.");
            Field(d => d.Name, nullable: true).Description("The name of the Project.");
        }
    }
}
