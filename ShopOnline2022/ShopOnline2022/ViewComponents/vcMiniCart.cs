using Microsoft.AspNetCore.Mvc;

namespace ShopOnline2022.ViewComponents
{
    public class vcMiniCart : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
