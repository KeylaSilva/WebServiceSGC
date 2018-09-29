using System.Web.Http;
using WebActivatorEx;
using WAGestaoCursos;
using Swashbuckle.Application;
using System;
using System.Xml.XPath;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WAGestaoCursos
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                          .EnableSwagger(c =>
                          {
                              c.SingleApiVersion("v1", "WSGestaoCursos");

                          })
                          .EnableSwaggerUi(c =>
                          {

                          });
        }

        protected static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\bin\WAGestaoCursos.xml", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
