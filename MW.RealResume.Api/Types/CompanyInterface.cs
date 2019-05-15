using GraphQL.Types;
using MW.RealResume.Model;

namespace MW.RealResume.Api.Types
{
    public class CompanyInterface : InterfaceGraphType<Company>
    {
        public CompanyInterface()
        {
            Name = "Company";
            Description = "Company Interface Description.";

            Field(d => d.Id).Description("The id of the company.");
            Field(d => d.Name, nullable: true).Description("The name of the company.");
            Field(d => d.Industry).Description("The Industry of the company.");
        }
    }
}
