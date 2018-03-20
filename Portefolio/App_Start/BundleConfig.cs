using System.Web;
using System.Web.Optimization;

namespace Portefolio
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/modernizr-2.8.1.min.js",
                      "~/Scripts/jquery.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/wow.min.js",
                      "~/Scripts/hippo-offcanvas.js",
                      "~/Scripts/jquery.easing.min.js",
                      "~/Scripts/jquery.magnific-popup.min.js",
                      "~/Scripts/jquery.shuffle.min.js",
                      "~/Scripts/scripts.js",
                      "~/Scripts/jquery.easypiechart.min.js",
                      "~/Scripts/jquery.easing.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/styles/Styles.min.css",
                      "~/styles/css/*.css",
                      "~/css/font-awesome.min.css",
                      "~/fonts/flaticon/flaticon.css"));
        }
    }
}
