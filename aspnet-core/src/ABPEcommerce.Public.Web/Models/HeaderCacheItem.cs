using ABPEcommerce.Public.ProductCategories;
using System.Collections.Generic;

namespace ABPEcommerce.Public.Web.Models
{
    public class HeaderCacheItem
    {
        public List<ProductCategoryInListDto> Categories { set; get; }
    }
}
