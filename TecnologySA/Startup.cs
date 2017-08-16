using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TecnologySA.Startup))]
namespace TecnologySA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
