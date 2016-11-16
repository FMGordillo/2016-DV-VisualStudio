using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP7_FMGordillo.Startup))]
namespace TP7_FMGordillo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
