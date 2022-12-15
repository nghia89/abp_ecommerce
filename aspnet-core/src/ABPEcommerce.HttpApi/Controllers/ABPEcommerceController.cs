using ABPEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPEcommerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABPEcommerceController : AbpControllerBase
{
    protected ABPEcommerceController()
    {
        LocalizationResource = typeof(ABPEcommerceResource);
    }
}
