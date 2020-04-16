using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingThemeApplication.Startup))]
namespace TestingThemeApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
