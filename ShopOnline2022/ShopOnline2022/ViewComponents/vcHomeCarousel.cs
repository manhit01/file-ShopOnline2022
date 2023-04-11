using Microsoft.AspNetCore.Mvc;
using ShopOnline2022.Models;

namespace ShopOnline2022.ViewComponents
{
    public class vcHomeCarousel : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DBContext db = new DBContext();
            var data = db.Pictures
                         .Where(x => x.PictureCategoryID == 1 && x.Status == true)  
                         .OrderBy(x => x.Position)
                         .ToList();
            return View(data);
        }
    }
}
