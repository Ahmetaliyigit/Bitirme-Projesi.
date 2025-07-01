using BLL;
using Microsoft.AspNetCore.Mvc;

namespace AHMAYTI_B12_WEB.ViewComponents.Category
{
    public class SelectUpCategoryViewComponent : ViewComponent
    {
        private readonly CategoryService categorys;

        public SelectUpCategoryViewComponent()
        {
            categorys = new CategoryService();
        }

        public async Task<IViewComponentResult> InvokeAsync(int Id)
        {
            return View(await categorys.GettAllAsync());
        }
    }
}
