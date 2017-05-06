using POC_REPOSITORY.Bussiness;
using POC_REPOSITORY.Data.DatabaseContext;
using POC_REPOSITORY.Data.Repository;
using POC_REPOSITORY.Data.Repository.Contracts;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace POC_REPOSITORY
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            using (var db = new DataContext("POC_Repository_Database"))
            {
                db.Database.Initialize(false);
            }

            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle(); ;

            // 2. Configure the container (register)
            container.Register<IUnitOfWork,UnitOfWork>(Lifestyle.Scoped);
            container.Register<IRegisterManager, RegisterManager>(Lifestyle.Scoped);

            // 3. Optionally verify the container's configuration.
            container.Verify();

            // 4. Register the container as MVC3 IDependencyResolver.
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));


        }
    }
}
