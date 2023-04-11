using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopOnline2022.Models;

namespace ShopOnline2022.ViewComponents
{
    public class vcProductHot : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DBContext db = new DBContext();
            var data = db.Products
                         .Where(x => x.Status == true)
                         .OrderByDescending(x => x.OldPrice - x.Price)
                         .Take(6)
                         .ToList();
            return View(data);
        }
    }
}
