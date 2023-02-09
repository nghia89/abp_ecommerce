using Volo.Abp.Modularity;

namespace ABPEcommerce;

[DependsOn(
    typeof(ABPEcommerceDomainTestModule)
    )]
public class ABPEcommerceApplicationTestModule : AbpModule
{

}
