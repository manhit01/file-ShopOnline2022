using Microsoft.AspNetCore.Mvc;

namespace ShopOnline2022.ViewComponents
{
    public class vcHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
