using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuAn.Startup))]
namespace DuAn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
