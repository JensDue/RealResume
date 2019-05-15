using GraphQL.Types;
using MW.RealResume.DataAccess;
using MW.RealResume.Model;

namespace MW.RealResume.Api.Types
{
    public class EducationType : ObjectGraphType<Education>
    {
        public EducationType(Repository data)
        {
            Name = "Education";

            Field(h => h.Id).Description("The id of the education*.");
            Field(h => h.Name, true).Description("The name of the education.");
            Field(h => h.Timestamp).Description("Last edited timestamp.");
            Field(h => h.School);
            Field(h => h.Degree);
            Field(h => h.StartDate);
            Field(h => h.EndDate);

            //Interface<EducationInterface>();
        }
    }
}