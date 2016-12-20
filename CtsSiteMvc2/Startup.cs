using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CtsSiteMvc2.Startup))]
namespace CtsSiteMvc2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
