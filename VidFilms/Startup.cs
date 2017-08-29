using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidFilms.Startup))]
namespace VidFilms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
