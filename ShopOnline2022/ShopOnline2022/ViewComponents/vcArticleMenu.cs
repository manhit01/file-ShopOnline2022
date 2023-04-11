using Microsoft.AspNetCore.Mvc;
using ShopOnline2022.Models;

namespace ShopOnline2022.ViewComponents
{
    public class vcArticleMenu : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DBContext db = new DBContext();
            var data = db.ArticleCategories
                         .Where(x => x.Status == true)  
                         .OrderBy(x => x.Position)
                         .ToList();
            return View(data);
        }
    }
}
