using BLL.Abstract;
using BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret_Prjesi_AHMT.ViewComponents.Shop
{
    public class SeiectSideBarViewComponentPartial : ViewComponent
    {
        private readonly IProductService productServise;

        public SeiectSideBarViewComponentPartial(IProductService product)
        {
            productServise = product;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await productServise.GetAllAsync());
        }
    }
}
