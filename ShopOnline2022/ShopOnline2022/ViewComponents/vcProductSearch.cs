using Microsoft.AspNetCore.Mvc;

namespace ShopOnline2022.ViewComponents
{
    public class vcProductSearch : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
