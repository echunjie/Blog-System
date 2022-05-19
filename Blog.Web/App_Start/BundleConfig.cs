using System.Web;
using System.Web.Optimization;

namespace Blog.Web
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css").Include("~/Content/css/bootstrap.min.css", "~/Content/css/site.css"));

            bundles.Add(new ScriptBundle("~/jquery").Include("~/Content/js/jquery-3.4.1.min.js", "~/Content/js/jquery-3.4.1.slim.min.js",
                "~/Content/js/jquery.validate.min.js", "~/Content/js/jquery.validate.unobtrusive.js", "~/Content/js/bootstrap.min.js"));

 
        }
    }
}
