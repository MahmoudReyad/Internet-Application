using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App_01.Startup))]
namespace App_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
