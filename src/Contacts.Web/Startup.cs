using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Contacts.Repository.Concrete;
using Contacts.Web.App_Start;
using Microsoft.Owin;
using Owin;
using System.Reflection;
using System.Web.Mvc;

[assembly: OwinStartup(typeof(Contacts.Web.Startup))]

namespace Contacts.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureResolver(app);
        }

        private void ConfigureResolver(IAppBuilder app)
        {
            DependencyResolver.SetResolver(new AutofacDependencyResolver(ContactsDependencyResolver.GetLifetimeScope()));
        }
    }
}
