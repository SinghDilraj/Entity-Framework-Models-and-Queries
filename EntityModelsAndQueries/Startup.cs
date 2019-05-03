using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityModelsAndQueries.Startup))]
namespace EntityModelsAndQueries
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
