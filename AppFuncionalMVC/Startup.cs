using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppFuncionalMVC.Startup))]
namespace AppFuncionalMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
