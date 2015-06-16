using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Contacts.Web.App_Start;
using Autofac.Integration.WebApi;

namespace Contacts.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            // Filter INTs for index
            config.Routes.MapHttpRoute(
                "DefaultApiWithPageIndex",
                "api/{controller}/{index}",
                new { index = 1 },
                new { index = @"\d+" }
            );

            // Filter GUIDs for ids
            config.Routes.MapHttpRoute(
                "DefaultApiWithId",
                "api/{controller}/{id}",
                new { id = @"\[a-z][A-Z][0-9]{8}-[a-z][A-Z][0-9]{4}-[a-z][A-Z][0-9]{4}-[a-z][A-Z][0-9]{4}-[a-z][A-Z][0-9]{12}" }
            );

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
            };
            config.DependencyResolver = new AutofacWebApiDependencyResolver(ContactsDependencyResolver.GetLifetimeScope());
        }
    }
}
