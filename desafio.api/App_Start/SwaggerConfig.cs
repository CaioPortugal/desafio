using System.Web.Http;
using WebActivatorEx;
using desafio_back;
using Swashbuckle.Application;
using System;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace desafio_back
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "Desafio");
                        c.IncludeXmlComments($@"{AppDomain.CurrentDomain.BaseDirectory}\bin\Swagger.xml");
                       
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.DocumentTitle("Desafio");
                        c.DocExpansion(DocExpansion.List);
                    });
        }
    }
}
