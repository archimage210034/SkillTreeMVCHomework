using SkillTreeMVCHomework.Models;
using SkillTreeMVCHomework.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace SkillTreeMVCHomework
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IPaymentService, PaymentService>();

            //container.RegisterType<IRepository<AccountBook>, RandomAccountBookRepository<AccountBook>>();

            container.RegisterType<IMyUnitOfWork, EFUnitOfWork>(new ContainerControlledLifetimeManager());
            container.RegisterType<IRepository<AccountBook>, SkillTreeDatabaseAccountBookRepository<AccountBook>>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}