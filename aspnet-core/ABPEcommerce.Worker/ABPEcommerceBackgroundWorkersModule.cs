using ABPEcommerce.Worker.MailCampaigns;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;
using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Caching.StackExchangeRedis;
using ABPEcommerce.EntityFrameworkCore;
using Microsoft.AspNetCore.DataProtection;

namespace ABPEcommerce.Worker
{
    [DependsOn(
     typeof(AbpAutofacModule),
     typeof(AbpBackgroundWorkersModule),
     typeof(AbpCachingStackExchangeRedisModule)
 )]
    public class TeduEcommerceBackgroundWorkersModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            var hostEnvironment = context.Services.GetSingletonInstance<IHostEnvironment>();

            context.Services.AddHostedService<ABPEcommerceBackgroundWorkersHostedService>();

            Configure<AbpDistributedCacheOptions>(options =>
            {
                options.KeyPrefix = "ABPEcommerce:";
            });
            var dataProtectionBuilder = context.Services.AddDataProtection().SetApplicationName("ABPEcommerce");
            if (!hostEnvironment.IsDevelopment())
            {
                var redis = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]);
                dataProtectionBuilder.PersistKeysToStackExchangeRedis(redis, "ABPEcommerce-Protection-Keys");
            }

        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            context.AddBackgroundWorkerAsync<EmailMarketingWorker>();
        }
    }
}
