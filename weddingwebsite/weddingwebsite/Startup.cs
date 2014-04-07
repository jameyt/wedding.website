using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(weddingwebsite.Startup))]
namespace weddingwebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
