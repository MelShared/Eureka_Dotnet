using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.UI.WebControls;
using RouteParameter = System.Web.Http.RouteParameter;

namespace WS_EUREKA_RESTFUL_DOTNET
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Habilitar CORS para todas las solicitudes
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Otras configuraciones de Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}