using System.Net;
using System.Net.Security;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LogicWebAPI
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services


			// Web API routes
			config.MapHttpAttributeRoutes();

			ServicePointManager.ServerCertificateValidationCallback = new
				RemoteCertificateValidationCallback
				(
					delegate { return true; }
				);

			var corsAttr = new EnableCorsAttribute("*", "*", "*");
			config.EnableCors(corsAttr);

			//config.Routes.MapHttpRoute(
			//	name: "DefaultApi",
			//	routeTemplate: "api/{controller}/{id}",
			//	defaults: new { id = RouteParameter.Optional }
			//);

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{action}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}
