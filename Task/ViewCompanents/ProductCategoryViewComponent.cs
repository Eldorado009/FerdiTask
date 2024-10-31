using Microsoft.AspNetCore.Mvc;
using Task.Services;
using Task.Services.Interfaces;
using Task.ViewModels;

namespace Task.ViewCompanents
{
    public class ProductCategoryViewComponent : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductCategoryViewComponent(IProductService productService,
                                    ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await System.Threading.Tasks.Task.FromResult(View(new ProductCategoryHomeVM()
            {
                Products = await _productService.GetAllAsync(),
                Categories = await _categoryService.GetAllAsync()

            }));
            
          
            
        }

    }
}
