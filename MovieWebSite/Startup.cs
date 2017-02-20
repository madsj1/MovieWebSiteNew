using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Stormpath.AspNet;
using Stormpath.Configuration.Abstractions;

[assembly: OwinStartup(typeof(MovieWebSite.Startup))]

namespace MovieWebSite
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            app.UseStormpath(new StormpathConfiguration()
            {
                Client = new ClientConfiguration()
                {
                    ApiKey = new ClientApiKeyConfiguration()
                    {
                        Id = "1NA4DSNJ42K2IN7AW6PLDSSQG",
                        Secret = "DjpiqKPw0zrogEd/X4go3bW897SVo/GGCrAYXqmNOIY"
                    }
                }
            });

            // Any other OWIN middleware here...
        }
    }
}
