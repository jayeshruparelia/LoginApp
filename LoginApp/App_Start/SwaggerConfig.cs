using System.Web.Http;
using WebActivatorEx;
using LocalAccountsApp;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace LocalAccountsApp
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                         
                        c.SingleApiVersion("vAlpha", "LoginApp");

                          
                    })
                .EnableSwaggerUi(c =>
                    {
                          
                    });
        }
    }
}
