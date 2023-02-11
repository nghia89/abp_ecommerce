using ABPEcommerce.Public.ProductCategories;
using ABPEcommerce.Public.Products;
using System.Collections.Generic;

namespace ABPEcommerce.Public.Web.Models
{
    public class HomeCacheItem
    {
        public List<ProductCategoryInListDto> Categories { set; get; }
        public List<ProductInListDto> TopSellerProducts { set; get; }
    }
}
