using System.Web;
using System.Web.Optimization;

namespace CtsSiteMvc2
{
    public class BundleConfig
    {
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var bowerMiniPath = new {mini = "~/bower_components/greensock-js/src/minified",
                plugins = "~/bower_components/greensock-js/src/minified/plugins",
                easing = "~/bower_components/greensock-js/src/minified/plugins/easing"
            };

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/less-{version}.js",
                        $"{bowerMiniPath.plugins}/CSSPlugin.min.js",
                        $"{bowerMiniPath.easing}/EasePack.min.js",
                        $"{bowerMiniPath.plugins}/AttrPlugin.min.js",
                        $"{bowerMiniPath.plugins}/AttrPlugin.min.js",
                        $"{bowerMiniPath.mini}/jquery.gsap.min.js",
                        $"{bowerMiniPath.mini}/TimelineLite.min.js",
                        $"{bowerMiniPath.mini}/TimelineMax.min.js",
                        $"{bowerMiniPath.mini}/TweenLite.min.js",
                        $"{bowerMiniPath.mini}/TweenMax.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.unobtrusive*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // используйте средство сборки на сайте http://modernizr.com, чтобы выбрать только нужные тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/reset_styles.css",
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/mycss.css"));

        }
    }
}
