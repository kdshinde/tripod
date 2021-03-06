﻿using System;
using SimpleInjector;
using Tripod.Services.Audit;
using Tripod.Services.Configuration;
using Tripod.Services.Cryptography;
using Tripod.Services.EntityFramework;
using Tripod.Services.FluentValidation;
using Tripod.Services.Net;
using Tripod.Services.Security;
using Tripod.Services.Transactions;

namespace Tripod.Services
{
    public static class CompositionRoot
    {
        public static void ComposeRoot(this Container container, RootCompositionSettings settings)
        {
            settings = settings ?? new RootCompositionSettings();
#if !DEBUG
            settings.IsGreenfield = false;
#endif
            container.Register<IServiceProvider>(() => container, Lifestyle.Singleton);
            container.RegisterConfiguration();
            container.RegisterCryptography();
            container.RegisterExceptionAuditor();
            container.RegisterMailDelivery();
            container.RegisterEntityFramework(settings.IsGreenfield);
            container.RegisterSecurity();
            container.RegisterFluentValidation(settings.FluentValidatorAssemblies);
            container.RegisterQueryTransactions(settings.QueryHandlerAssemblies);
            container.RegisterCommandTransactions(settings.CommandHandlerAssemblies);
        }
    }
}
