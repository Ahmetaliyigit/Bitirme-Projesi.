using Microsoft.AspNetCore.Mvc;

namespace AHMAYTI_B12_WEB.ViewComponents.Featured
{
    public class SelectFeaturedViewComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
