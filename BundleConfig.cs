using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace StackOverflowClone
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include("~/Scripts/jquery-3.3.1.js"));
            bundles.Add(new ScriptBundle("~/Scripts/bootstrap1").Include("~/Scripts/umd/popper.js"));
            bundles.Add(new ScriptBundle("~/Scripts/bootstrap2").Include("~/Scripts/bootstrap.js"));
            bundles.Add(new StyleBundle("~/Styles/bootstrap").Include("~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Styles/site").Include("~/Content/Styles.css"));
            
            BundleTable.EnableOptimizations = true;
        }
    }
}


