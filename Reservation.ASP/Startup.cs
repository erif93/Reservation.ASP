using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reservation.ASP.Startup))]
namespace Reservation.ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
