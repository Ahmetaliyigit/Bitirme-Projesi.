using BLL;
using Microsoft.AspNetCore.Mvc;

namespace AHMAYTI_B12_WEB.ViewComponents.Product
{
    public class SelectProductViewComponentView : ViewComponent
    {
        private readonly ProductService products;

        public SelectProductViewComponentView()
        {
            products = new ProductService();
        }

        public async Task<IViewComponentResult> InvokeAsync(int Id)
        {
            if (Id == 0)
            {
               return View(await products.GetAllAsync());
            }
            else
            {
                return View(await products.GetAllAsync(i => i.CategoryId == Id));
            }
           
        }

    }
}
