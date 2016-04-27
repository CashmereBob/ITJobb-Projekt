using ITJobb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ITJobb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Database.SetInitializer<ITJobbDbContext>(new DropCreateDatabaseIfModelChanges<ITJobbDbContext>());

            //Database.SetInitializer<ITJobbDbContext>(new AnvandareInitiallizer());

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ITJobb.Models.ITJobbDbContext, ITJobb.Migrations.Configuration>());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
