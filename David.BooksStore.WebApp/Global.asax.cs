using David.BooksStore.Domain.Entities;
using David.BooksStore.WebApp.App_Start;
using David.BooksStore.WebApp.Areas.Admin.Infrastructure.Binders;
using System.Web.Mvc;
using System.Web.Routing;

namespace David.BooksStore.WebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Register Autofac configure
            AutofacConfig.Register();

            // 
            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());

    }
    }
}
