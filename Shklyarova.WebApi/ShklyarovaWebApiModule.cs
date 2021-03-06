﻿using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace Shklyarova
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ShklyarovaApplicationModule))]
    public class ShklyarovaWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ShklyarovaApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
