﻿using System.Web;
using System.Web.Optimization;

namespace Tasks
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/JavaScript/Framework/jquery-{version}.js",
                        "~/JavaScript/Framework/jquery-ui-{version}.js",
                        "~/JavaScript/Framework/jquery.nicescroll.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/JavaScript/Framework/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/JavaScript/Framework/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/JavaScript/Framework/bootstrap.js",
                      "~/JavaScript/Framework/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/core").Include(
                      "~/JavaScript/Controllers/Utils/Core.js",
                      "~/JavaScript/Menu.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(                                            
                      "~/CSS/Global/bootstrap.css",
                      "~/CSS/Global/jquery-ui.css",
                      "~/CSS/Modules/menu.css",
                      "~/CSS/Modules/header.css",
                      "~/CSS/Global/global.css"));
        }
    }
}
