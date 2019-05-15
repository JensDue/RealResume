using System.Security.Claims;

namespace MW.RealResume.WebSite
{
    public class GraphQLUserContext
    {
        public ClaimsPrincipal User { get; set; }
    }
}