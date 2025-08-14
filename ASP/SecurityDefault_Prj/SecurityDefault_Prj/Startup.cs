using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityDefault_Prj.Startup))]
namespace SecurityDefault_Prj
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
