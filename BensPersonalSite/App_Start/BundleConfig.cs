using System.Web;
using System.Web.Optimization;

namespace BensPersonalSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;
            bundles.Add(new ScriptBundle("~/bundles/jquery", "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.0.0.min.js").Include(
                        "~/Scripts/jquery-3.0.0.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap", "https://ajax.aspnetcdn.com/ajax/bootstrap/4.0.0/bootstrap.min.js").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/fontawesome", "https://use.fontawesome.com/releases/v5.3.1/css/all.css"));

            bundles.Add(new ScriptBundle("~/bundles/pong").Include(
                "~/Scripts/pong.js"));

            bundles.Add(new ScriptBundle("~/bundles/track").Include(
                "~/Scripts/send_pageview.js"));
        }


    }
}
