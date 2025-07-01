using Microsoft.AspNetCore.Mvc;

namespace AHMAYTI_B12_WEB.ViewComponents.Product
{
    public class SelectRecentProductViewComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
