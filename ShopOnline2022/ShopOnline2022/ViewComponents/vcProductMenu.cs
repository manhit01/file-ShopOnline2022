using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopOnline2022.Models;

namespace ShopOnline2022.ViewComponents
{
    public class vcProductMenu : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DBContext db = new DBContext();
            var data = db.ProductMainCategories
                         .Include(x => x.ProductCategories)
                         .Where(x => x.Status == true)
                         .OrderBy(x => x.Position)
                         .ToList();
            return View(data);
        }
    }
}
