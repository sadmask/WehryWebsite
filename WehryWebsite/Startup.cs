using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WehryWebsite.Startup))]
namespace WehryWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
