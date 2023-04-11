using Microsoft.AspNetCore.Mvc;
using ShopOnline2022.Models;
using System.Diagnostics;

namespace ShopOnline2022.Controllers
{
    public class ArticleController : Controller
    {
        [Route("/tin-tuc", Name="ArticleList")]
        [Route("/tin-tuc/page/{page}", Name = "ArticleListByPage")]
        [Route("/tin-tuc/cat/{id?}/{title?}/{page?}", Name = "ArticleListByCat")]
        public IActionResult Index(int? ID, string? title, int? page)
        {
            ViewBag.Title = "Tin tức - ShopOnline";
            return View();
        }

        [Route("/gioi-thieu", Name = "ArticleIntro")]
        public IActionResult Intro()
        {
            ViewBag.Title = "Giới thiệu - ShopOnline";
            return View();
        }

        [Route("/tin-tuc/{ID}/{title}", Name = "ArticleDetail")]
        public IActionResult Detail(int ID, string title)
        {
            DBContext db = new DBContext();
            var data = db.Articles.FirstOrDefault(x => x.ArticleID == ID);

            if (data == null)
                return RedirectToRoute("NotFound404");

            ViewBag.Title = data.Title;
            return View(data);
        }
    }
}