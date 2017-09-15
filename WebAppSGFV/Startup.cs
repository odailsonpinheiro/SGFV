using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppSGFV.Startup))]
namespace WebAppSGFV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
