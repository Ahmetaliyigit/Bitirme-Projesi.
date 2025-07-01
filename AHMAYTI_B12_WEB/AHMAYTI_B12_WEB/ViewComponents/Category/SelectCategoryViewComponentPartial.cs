using BLL;
using Microsoft.AspNetCore.Mvc;

namespace AHMAYTI_B12_WEB.ViewComponents.Category
{
    public class SelectCategoryViewComponentPartial : ViewComponent
    {
        private readonly CategoryService categorys;

        public SelectCategoryViewComponentPartial()
        {
            categorys = new CategoryService();
        }

        public async Task<IViewComponentResult> InvokeAsync(int Id)
        {
            return View(await categorys.GettAllAsync());
        }
    }
}
