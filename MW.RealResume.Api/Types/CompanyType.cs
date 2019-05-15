using GraphQL.Types;
using MW.RealResume.DataAccess;
using MW.RealResume.Model;

namespace MW.RealResume.Api.Types
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType(Repository data)
        {
            Name = "Company";
            Description = "Company Type Description.";
            
            Field(h => h.Id).Description("The id of the company.");
            Field(h => h.Name, nullable: true).Description("The name of the company.");
            Field(h => h.Timestamp).Description("Last edited timestamp.");
            Field(h => h.Description);
            Field(h => h.Headquarters);
            Field(h => h.Industry);
            Field(h => h.Website);

            //Interface<CompanyInterface>();
        }
    }
}
