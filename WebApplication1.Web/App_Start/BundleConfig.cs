using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApplication1.Web.App_Start
{
     public class BundleConfig
     {
          public static void RegisterBundles(BundleCollection bundles)
          {
               bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/bootstrap.min.css",
                    new CssRewriteUrlTransform()));
               bundles.Add(new StyleBundle("~/bundles/style/css").Include("~/Content/style.css", 
                    new CssRewriteUrlTransform()));

               bundles.Add(new ScriptBundle("~/bundles/jquery/js")
                    .Include("~/Scripts/jquery-3.4.1.min.js")
                    .Include("~/Scripts/jquery.fancybox.pack.js"));
               bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Scripts/bootstrap.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/custom/js")
                    .Include("~/Scripts/script.js")
                    .Include("~/Scripts/main.js"));
          }
     }
}