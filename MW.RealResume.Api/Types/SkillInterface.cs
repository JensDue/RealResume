using GraphQL.Types;
using MW.RealResume.Model;

namespace MW.RealResume.Api.Types
{
    public class SkillInterface : InterfaceGraphType<Skill>
    {
        public SkillInterface()
        {
            Name = "Skill";

            Field(d => d.Id).Description("The id of the Skill.");
            Field(d => d.Name, nullable: true).Description("The name of the Skill.");
            Field(d => d.Timestamp);
            Field(d => d.Level);
        }
    }
}
