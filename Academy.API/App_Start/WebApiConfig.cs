using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Academy.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API
            CorsSettings(config);

            // Rutas de Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void CorsSettings(HttpConfiguration config)
        {
            string allowsSites = "*";
            string headers = "*";
            string methods = "*";

            EnableCorsAttribute cors = new EnableCorsAttribute(allowsSites, headers: headers, methods: methods);
            config.EnableCors(cors);
        }

    }
}
