using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UsandoKnockout.Startup))]
namespace UsandoKnockout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
