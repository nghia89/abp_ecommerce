using System;

namespace ABPEcommerce.Admin.Catalog.Products
{
    public class ProductListFilterDto : BaseListFilterDto
    {
        public Guid? CategoryId { get; set; }
    }
}

