using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Navio.Startup))]
namespace Navio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
