using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authenticate_Security_Prj.Startup))]
namespace Authenticate_Security_Prj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
