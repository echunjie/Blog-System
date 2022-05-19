using Blog.Data.Service;
using Blog.Data.Service.impl;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Blog.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IArticeService, ArticleService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}