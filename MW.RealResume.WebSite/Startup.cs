using GraphQL;
using GraphQL.Http;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQL.Types;
using MW.RealResume.Api;
using MW.RealResume.Api.Types;
using MW.RealResume.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MW.RealResume.WebSite
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));

            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDocumentWriter, DocumentWriter>();

            services.AddSingleton<Repository>();
            services.AddSingleton<StaticData>();

            services.AddSingleton<DemoQuery>();

            services.AddSingleton<CompanyType>();
            services.AddSingleton<CompanyInterface>();

            services.AddSingleton<EducationType>();
            services.AddSingleton<EducationInterface>();

            services.AddSingleton<ProjectType>();
            services.AddSingleton<ProjectInterface>();

            services.AddSingleton<SkillType>();
            services.AddSingleton<SkillInterface>();

            services.AddSingleton<ResumeType>();

            services.AddSingleton<ISchema, DemoSchema>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddGraphQL(_ =>
                {
                    _.EnableMetrics = true;
                    _.ExposeExceptions = true;
                })
                .AddUserContextBuilder(httpContext => new GraphQLUserContext {User = httpContext.User});
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();

            //loggerFactory.AddConsole();
            //app.UseDeveloperExceptionPage();

            // add http for Schema at default url /graphql
            app.UseGraphQL<ISchema>("/graphql");

            // use graphql-playground at default url /ui/playground
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions
            {
                Path = "/ui/playground"
            });
        }
    }
}