﻿using System;
using LightInject;

namespace Solar.Infrastructure.Common.DependencyInjection
{
    public static class LifeTimeFactory
    {
        public static readonly Func<ILifetime> PerContainer = () => new PerContainerLifetime();
        public static readonly Func<ILifetime> PerRequest = () => new PerRequestLifeTime();
        public static readonly Func<ILifetime> PerScope = () => new PerScopeLifetime();
    }
}