using GraphQL.Types;
using MW.RealResume.DataAccess;
using MW.RealResume.Model;

namespace MW.RealResume.Api.Types
{
    public class SkillType : ObjectGraphType<Skill>
    {
        public SkillType(Repository data)
        {
            Name = "Skill";
            Description = "Description in Type";

            Field(h => h.Id).Description("The id of the skill.");
            Field(h => h.Name, true).Description("The name of the skill.");
            Field(h => h.Timestamp).Description("Last edited timestamp.");
            Field(h => h.Level);

            //Interface<SkillInterface>();
        }
    }
}