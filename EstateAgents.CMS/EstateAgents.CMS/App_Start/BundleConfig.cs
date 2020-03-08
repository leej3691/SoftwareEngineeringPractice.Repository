using BundleTransformer.Core.Bundles;
using System.Web;
using System.Web.Optimization;

namespace EstateAgents.CMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            bundles.Add(new CustomStyleBundle("~/style/bootstrap").Include("~/content/bootswatch/build.less"));
            bundles.Add(new StyleBundle("~/style/jquery-datatables-bootstrap", "https://cdn.datatables.net/1.10.12/css/dataTables.bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/style/jquery-datatables-buttons", "https://cdn.datatables.net/buttons/1.10.12/css/buttons.bootstrap.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/style/font-awesome", "https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css").Include("~/content/font-awesome.css"));
            bundles.Add(new ScriptBundle("~/scripts/jquery-datatables", "https://cdn.datatables.net/1.10.12/js/jquery.dataTables.min.js"));
            bundles.Add(new ScriptBundle("~/scripts/jquery-datatables-buttons", "https://cdn.datatables.net/buttons/1.10.12/js/dataTables.buttons.min.js"));
            bundles.Add(new ScriptBundle("~/scripts/jquery-datatables-buttons-bootstrap", "https://cdn.datatables.net/buttons/1.10.12/js/buttons.bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/scripts/jquery-datatables-colvis", "https://cdn.datatables.net/buttons/1.10.12/js/buttons.colVis.min.js"));
            bundles.Add(new ScriptBundle("~/scripts/jquery-datatables-buttons-html5", "https://cdn.datatables.net/buttons/1.10.12/js/buttons.html5.min.js"));
            bundles.Add(new ScriptBundle("~/scripts/jquery-datatables-bootstrap", "https://cdn.datatables.net/1.10.12/js/dataTables.bootstrap.min.js"));
        }
    }
}
