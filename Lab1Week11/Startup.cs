using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab1Week11.Startup))]
namespace Lab1Week11
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
