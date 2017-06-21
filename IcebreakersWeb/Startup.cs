using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IcebreakersWeb.Startup))]
namespace IcebreakersWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
