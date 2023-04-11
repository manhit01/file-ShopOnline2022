using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopOnline2022.Models;
using System.Diagnostics;

namespace ShopOnline2022.Controllers
{
    public class ProductController : Controller
    {
        [Route("/san-pham", Name = "ProductList")]
        [Route("/san-pham/page/{page}", Name = "ProductListByPage")]
        [Route("/san-pham/mid/{mid?}/{title?}/{page?}", Name = "ProductListByMainCat")]
        [Route("/san-pham/mid/{mid?}/cid/{cid?}/{title?}/{page?}", Name = "ProductListBySubCat")]
        public IActionResult Index(int? mid, int? cid, string? title, int? page)
        {
            string pagingUrl = string.Empty;

            DBContext db = new DBContext();
            var query = db.Products
                          .Include(x => x.ProductCategory)
                          .Where(x => x.Status == true)
                          .OrderByDescending(x => x.CreateTime)
                          .AsQueryable();

            if (cid > 0)
            {
                var catItem = db.ProductCategories.FirstOrDefault(x => x.ProductCategoryID == cid);
                if (catItem != null)
                {
                    ViewBag.Heading = catItem.Title;
                    ViewBag.Title = catItem.Title;
                }
                pagingUrl = $"/san-pham/mid/{mid}/cid/{cid}/{title}/{{0}}";
                query = query.Where(x => x.ProductCategoryID == cid);
            }
            else if (mid > 0)
            {
                var mainItem = db.ProductMainCategories.FirstOrDefault(x => x.ProductMainCategoryID == mid);
                if (mainItem != null)
                {
                    ViewBag.Heading = mainItem.Title;
                    ViewBag.Title = mainItem.Title;
                }
                pagingUrl = $"/san-pham/mid/{mid}/{title}/{{0}}";
                query = query.Where(x => x.ProductCategory.ProductMainCategoryID == mid);
            }
            else
            {
                ViewBag.Heading = "Sản phẩm";
                ViewBag.Title = "Sản phẩm";
                pagingUrl = $"/san-pham/page/{{0}}";
            }

            //Xử lý phân trang
            if (page == null || page < 1)
                page = 1;

            int pageSize = 15;
            int skip = (page.Value - 1) * pageSize;

            ViewBag.PagingTotal = query.Count();
            ViewBag.PagingSize = pageSize;
            ViewBag.PagingPage = page;
            ViewBag.PagingUrl = pagingUrl;

            var data = query.Skip(skip).Take(pageSize).ToList();
            return View(data);
        }

        [Route("/tim-kiem", Name = "ProductSearch")]
        public IActionResult Search()
        {
            ViewBag.Title = "Tìm kiếm - ShopOnline";
            return View();
        }

        [Route("/san-pham/{ID}/{title}", Name = "ProductDetail")]
        public IActionResult Detail(int ID, string title)
        {
            DBContext db = new DBContext();
            var data = db.Products
                         .FirstOrDefault(x => x.ProductID == ID && x.Status == true);

            if (data == null)
            {
                return RedirectToRoute("NotFound404");
            }

            ViewBag.Title = data.Title;
            return View(data);
        }
    }
}