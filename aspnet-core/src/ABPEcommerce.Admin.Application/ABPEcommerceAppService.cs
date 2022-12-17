using ABPEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace ABPEcommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class ABPEcommerceAppService : ApplicationService
{
    protected ABPEcommerceAppService()
    {
        LocalizationResource = typeof(ABPEcommerceResource);
    }
}