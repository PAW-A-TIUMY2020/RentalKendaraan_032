using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalKendaraan_032.Startup))]
namespace RentalKendaraan_032
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
