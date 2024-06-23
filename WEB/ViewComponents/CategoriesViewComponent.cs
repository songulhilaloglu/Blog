using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;

namespace WEB.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;

        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await categoryService.GetAllCategoriesAsync();
            return View(categories);
        }
    }
}
