using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigitalSignage.Startup))]
namespace DigitalSignage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
