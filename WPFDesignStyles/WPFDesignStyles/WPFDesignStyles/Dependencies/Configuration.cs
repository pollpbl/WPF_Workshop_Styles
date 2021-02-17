using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;
using WPFDesignStyles.BusinessLogic.Services.Dialogs;
using WPFDesignStyles.BusinessLogic.Services.Messaging;
using WPFDesignStyles.Services.DialogService;
using WPFDesignStyles.Services.Messaging;

namespace WPFDesignStyles.Dependencies
{
    public static class Configuration
    {
        private static bool configured = false;

        public static void Configure(IUnityContainer container)
        {
            if (configured)
                return;

            container.RegisterType<IMessagingService, MessagingService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IDialogService, DialogService>(new ContainerControlledLifetimeManager());

            WPFDesignStyles.BusinessLogic.Dependencies.Configuration.Configure(container);

            configured = true;
        }
    }
}
