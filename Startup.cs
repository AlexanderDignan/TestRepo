using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaacTapTerminalApp.Startup))]
namespace TaacTapTerminalApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
