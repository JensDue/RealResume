using GraphQL;
using GraphQL.Types;

namespace MW.RealResume.Api
{
    public class DemoSchema : Schema
    {
        public DemoSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<DemoQuery>();
        }
    }
}
