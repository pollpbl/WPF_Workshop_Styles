using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;
using WPFDesignStyles.BusinessLogic.Services.EventBus;
using WPFDesignStyles.BusinessLogic.Services.Paths;

namespace WPFDesignStyles.BusinessLogic.Dependencies
{
    public static class Configuration
    {
        private static bool isConfigured = false;

        public static void Configure(IUnityContainer container)
        {
            if (isConfigured)
                return;
            isConfigured = true;

            // Register types
            container.RegisterType<IEventBus, EventBus>(new ContainerControlledLifetimeManager());
            container.RegisterType<IPathService, PathService>(new ContainerControlledLifetimeManager());
        }
    }
}
