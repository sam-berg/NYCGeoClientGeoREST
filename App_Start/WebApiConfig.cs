using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;

namespace GeoREST
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {


      config.Routes.MapHttpRoute("DefaultApiWithAction", "{controller}/{action}");
      config.Routes.MapHttpRoute("DefaultApiGet", "{controller}", new { action = "Get" }, new { httpMethod = new HttpMethodConstraint(System.Net.Http.HttpMethod.Get) });

      config.Routes.MapHttpRoute(
  name: "Default",
  routeTemplate: "GeocodeServer",
  defaults: new { controller = "GeocodeServer" }
);

      return;

      config.Routes.MapHttpRoute(
        name: "Default",
        routeTemplate: "GeocodeServer",
        defaults: new { controller = "GeocodeServer"}
      );

      config.Routes.MapHttpRoute(
  name: "Find Address Candidates",
  routeTemplate: "GeocodeServer/findAddressCandidates",
  defaults: new { controller = "GeocodeServer", action = "findAddressCandidates" }
  );
  

    }
  }
}
