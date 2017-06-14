using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SinglePageWeddingWebsite.Startup))]
namespace SinglePageWeddingWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
