using Volo.Abp.Modularity;

namespace ABPEcommerce;

[DependsOn(
    typeof(ABPEcommerceApplicationModule),
    typeof(ABPEcommerceDomainTestModule)
    )]
public class ABPEcommerceApplicationTestModule : AbpModule
{

}
