using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ABPEcommerce;

[Dependency(ReplaceServices = true)]
public class ABPEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ABPEcommerce";
}
