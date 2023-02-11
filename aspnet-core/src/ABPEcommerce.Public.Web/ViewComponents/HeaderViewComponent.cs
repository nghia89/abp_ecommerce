﻿using ABPEcommerce.Public.ProductCategories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ABPEcommerce.Public.Web.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly IProductCategoriesAppService _productCategoriesAppService;
        public HeaderViewComponent(IProductCategoriesAppService productCategoriesAppService)
        {
            _productCategoriesAppService = productCategoriesAppService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _productCategoriesAppService.GetListAllAsync();
            return View(model);
        }
    }
}
