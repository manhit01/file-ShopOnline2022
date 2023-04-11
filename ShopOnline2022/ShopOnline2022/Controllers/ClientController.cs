using Microsoft.AspNetCore.Mvc;
using ShopOnline2022.Models;
using System.Diagnostics;

namespace ShopOnline2022.Controllers
{
    public class ClientController : Controller
    {
        [Route("/dang-nhap", Name="Login")]
        public IActionResult Login()
        {
            ViewBag.Title = "Đăng nhập - ShopOnline";
            return View();
        }

        [Route("/dang-ky", Name = "Register")]
        public IActionResult Register()
        {
            ViewBag.Title = "Đăng ký - ShopOnline";
            return View();
        }
    }
}