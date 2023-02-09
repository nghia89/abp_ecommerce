using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ABPEcommerce.Public.Web;

[Dependency(ReplaceServices = true)]
public class PublicBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Public";
}
