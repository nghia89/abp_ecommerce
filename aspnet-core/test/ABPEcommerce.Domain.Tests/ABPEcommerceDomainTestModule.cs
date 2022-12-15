using ABPEcommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABPEcommerce;

[DependsOn(
    typeof(ABPEcommerceEntityFrameworkCoreTestModule)
    )]
public class ABPEcommerceDomainTestModule : AbpModule
{

}
