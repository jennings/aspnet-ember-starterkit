using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using Ember;

namespace EmberStarterKit
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css")
                .IncludeDirectory("~/Content", "*.css", true));

            bundles.Add(new Bundle(EmberJs.BundleNames.Templates,
                new EmberHandlebarsBundleTransform())
                .IncludeDirectory(EmberJs.TemplatesPath, "*.hbs", true));

            bundles.Add(new ScriptBundle("~/Scripts/App")
                .IncludeDirectory("~/Scripts/App", "*.js", true));
        }
    }
}