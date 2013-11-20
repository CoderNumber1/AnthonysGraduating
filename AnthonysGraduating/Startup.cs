using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnthonysGraduating.Startup))]
namespace AnthonysGraduating
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
