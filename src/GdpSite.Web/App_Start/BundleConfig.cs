using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using BundleTransformer.Core.Transformers;

namespace GdpSite.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var cssTransformer = new CssTransformer();

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/commonStyles", cssTransformer)
                .Include("~/Content/site.less"));

	        bundles.Add(new ScriptBundle("~/bundles/app")
				.Include("~/Scripts/bootstrap.js")
				.Include("~/Scripts/app.js"));
        }
    }
}