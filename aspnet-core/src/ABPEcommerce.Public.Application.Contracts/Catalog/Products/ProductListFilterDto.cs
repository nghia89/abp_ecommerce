using ABPEcommerce.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABPEcommerce.Public.Products
{
    public class ProductListFilterDto : BaseListFilterDto
    {
        public Guid? CategoryId { get; set; }
    }
}
