using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MVCChat.Startup))]
namespace MVCChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}