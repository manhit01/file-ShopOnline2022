using Microsoft.AspNetCore.Mvc;
using ShopOnline2022.Models;
using System.Diagnostics;

namespace ShopOnline2022.Controllers
{
    public class HomeController : Controller
    {
        [Route("/", Name = "Home")]
        public IActionResult Index()
        {
            ViewBag.Title = "Trang chủ - ShopOnline";
            return View();
        }

        [Route("/404", Name = "NotFound404")]
        public IActionResult NotFound404()
        {
            ViewBag.Title = "404 - Nội dung không tồn tại - ShopOnline";
            return View();
        }
    }
}