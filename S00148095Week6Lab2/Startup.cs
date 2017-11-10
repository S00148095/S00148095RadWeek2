using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S00148095Week6Lab2.Startup))]
namespace S00148095Week6Lab2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
