using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Brewery_Tracker.Startup))]
namespace Brewery_Tracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
