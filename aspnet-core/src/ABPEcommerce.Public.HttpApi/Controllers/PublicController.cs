using ABPEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPEcommerce.Public.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PublicController : AbpControllerBase
{
    protected PublicController()
    {
        LocalizationResource = typeof(ABPEcommerceResource);
    }
}
