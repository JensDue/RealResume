using GraphQL.Types;
using MW.RealResume.Model;

namespace MW.RealResume.Api.Types
{
    public class EducationInterface : InterfaceGraphType<Education>
    {
        public EducationInterface()
        {
            Name = "Education";

            Field(d => d.Id).Description("The id of the character.");
            Field(d => d.Name, nullable: true).Description("The name of the character.");
            Field(d => d.School, nullable: true).Description("The School of the character.");
        }
    }
}
