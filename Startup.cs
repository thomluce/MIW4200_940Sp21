using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIW4200_940.Startup))]
namespace MIW4200_940
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
