﻿using Autofac;

namespace Xamarin.Summit.iOS
{
    public class PlatformSpecificModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<ScreenSizeService>().As<IScreenSizeService>();
        }
    }
}