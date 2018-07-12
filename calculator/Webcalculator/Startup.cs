using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webcalculator.Startup))]
namespace Webcalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
