using System.Web;
using System.Web.Optimization;

namespace Carli
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/fontawesome.js",
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.bundle.min.js",
                        "~/Scripts/jquery.easing.min.js",
                        "~/Scripts/jquery.magnific-popup.min.js",
                        "~/Scripts/scripts.js"));
            
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/Merriweather.css",
                "~/Content/MerriweatherExtended.css",
                "~/Content/magnific-popup.min.css",
                "~/Content/styles.css"));
        }
    }
}
