using ABPEcommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ABPEcommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ABPEcommerceEntityFrameworkCoreModule)
    )]
public class ABPEcommerceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
