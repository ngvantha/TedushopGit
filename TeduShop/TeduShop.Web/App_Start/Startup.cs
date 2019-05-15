using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Owin;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TeduShop.Data;
using TeduShop.Data.Infratructure;
using TeduShop.Data.Repositoris;
using TeduShop.Service;

[assembly: OwinStartup(typeof(TeduShop.Web.App_Start.Startup))]

namespace TeduShop.Web.App_Start
{
 
        public partial class Startup
        {
            public void Configuration(IAppBuilder app)
            {
                ConfigAutofac(app);
                //ConfigureAuth(app);
            }

            private void ConfigAutofac(IAppBuilder app)
            {
                var builder = new ContainerBuilder();
                builder.RegisterControllers(Assembly.GetExecutingAssembly());
                //Asp.net Identity Account
                //builder.RegisterType<ApplicationUserStore>().As<IUserStore<ApplicationUser>>().InstancePerRequest();
                //builder.RegisterType<ApplicationUserManager>().AsSelf().InstancePerRequest();
                //builder.RegisterType<ApplicationSignInManager>().AsSelf().InstancePerRequest();
                //builder.Register(c => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
                //builder.Register(c => app.GetDataProtectionProvider()).InstancePerRequest();

                // Register your Web API controllers.
                builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers

                builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

                builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

                builder.RegisterType<TeduShopDbContext>().AsSelf().InstancePerRequest();

                // Repositories
                builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerRequest();

                // Services
                builder.RegisterAssemblyTypes(typeof(PostCategoryService).Assembly).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerRequest();

                Autofac.IContainer container = builder.Build();
                DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

                GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver

                //var builder = new ContainerBuilder();
                //builder.RegisterControllers(Assembly.GetExecutingAssembly());
                //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
                //builder.RegisterType<UnitofWork>().As<IUnitofWork>().InstancePerRequest();
                //builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();
                //builder.RegisterType<TeduShopDbContext>().AsSelf().InstancePerRequest();
                ////Repository
                //builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
                //    .Where(t => t.Name.EndsWith("Repository"))
                //    .AsImplementedInterfaces().InstancePerRequest();
                ////Service
                //builder.RegisterAssemblyTypes(typeof(PostCategoryService).Assembly)
                //    .Where(t => t.Name.EndsWith("Service"))
                //    .AsImplementedInterfaces().InstancePerRequest();
                ////assign to Autofac
                //Autofac.IContainer container = builder.Build();
                //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
                //GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
            }
        }
    
}