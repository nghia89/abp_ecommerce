using System;
using System.Collections.Generic;
using System.Text;
using ABPEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace ABPEcommerce.Public;

/* Inherit your application services from this class.
 */
public abstract class PublicAppService : ApplicationService
{
    protected PublicAppService()
    {
        LocalizationResource = typeof(ABPEcommerceDomainSharedModule);
    }
}
