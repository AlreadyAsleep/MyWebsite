using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BensPersonalSite.Controllers;
namespace BensPersonalSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }


        protected void Application_Error(object sender, EventArgs e)
        {
            Server.ClearError();
            var routeData = new RouteData();
            routeData.Values["controller"] = "Error";

            if ((Context.Server.GetLastError() is HttpException) && ((Context.Server.GetLastError() as HttpException).GetHttpCode() != 404))
            {
                routeData.Values["action"] = "InternalError";
            }
            else
            { 
                routeData.Values["action"] = "NotFound";
            }
            Response.TrySkipIisCustomErrors = true;
            IController errorsController = new ErrorController();
            var wrapper = new HttpContextWrapper(Context);
            var rc = new RequestContext(wrapper, routeData);
            errorsController.Execute(rc);

            Response.End();
        }
    }
}
