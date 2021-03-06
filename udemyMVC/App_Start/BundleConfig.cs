﻿using System.Web;
using System.Web.Optimization;

namespace udemyMVC
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
									"~/js/jquery.min.js"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
								"~/js/bootstrap.min.js",
								"~/js/jquery.dataTables.min.js",
								"~/js/dataTables.bootstrap.min.js",
								"~/js/dataTables.colReorder.min.js",
								"~/js/jquery-ui.min.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
								"~/css/bootstrap.min.css",
								"~/css/jquery.dataTables.min.css",
								"~/css/jquery.dataTables_themeroller.min.css",
								"~/css/dataTables.bootstrap.min.css",
								"~/css/colReorder.bootstrap.min.css",
								"~/css/site.css",
								"~/css/jquery-ui.min.css",
								"~/css/jquery-ui.structure.min.css",
								"~/css/jquery-ui.theme.min.css"));
		}
	}
}
