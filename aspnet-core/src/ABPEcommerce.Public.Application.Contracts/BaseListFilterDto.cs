using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace ABPEcommerce.Public
{
    public class BaseListFilterDto : PagedResultRequestBase
    {
        public string Keyword { get; set; }
    }
}
