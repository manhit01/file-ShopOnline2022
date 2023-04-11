using Microsoft.AspNetCore.Mvc;
using ShopOnline2022.Models;

namespace ShopOnline2022.ViewComponents
{
    public class vcHomeArticle : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DBContext db = new DBContext();
            var data = db.Articles
                         .Where(x => x.Status == true)  
                         .OrderByDescending(x => Guid.NewGuid())
                         .Take(10)
                         .ToList();
            return View(data);
        }
    }
}
