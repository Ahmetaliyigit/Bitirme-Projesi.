using Microsoft.AspNetCore.Mvc;

namespace AHMAYTI_B12_WEB.ViewComponents.Offer
{
    public class SelectOfferViewComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        } 
    }

}
