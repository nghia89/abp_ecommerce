using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABPEcommerce;

[Dependency(ReplaceServices = true)]
public class ABPEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ABPEcommerce";
}
