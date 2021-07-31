using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace MessageAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                "DefaultApiWithId",
                "{controller}/{id}",
                new { id = RouteParameter.Optional },
                new { id = @"\d+" });
            config.Routes.MapHttpRoute(
                "DefaultApiGet",
                "{controller}",
                new { action = "Get" },
                new { httpMethod = new HttpMethodConstraint(HttpMethod.Get) });
            config.Routes.MapHttpRoute(
                "DefaultApiPost",
                "{controller}",
                new { action = "Post" },
                new { httpMethod = new HttpMethodConstraint(HttpMethod.Post) });
            config.Routes.MapHttpRoute(
                "DefaultApiPut",
                "{controller}",
                new { action = "Put" },
                new { httpMethod = new HttpMethodConstraint(HttpMethod.Put) });
        }
    }
}
