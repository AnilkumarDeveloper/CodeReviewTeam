using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleCodervw.Startup))]
namespace SampleCodervw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
