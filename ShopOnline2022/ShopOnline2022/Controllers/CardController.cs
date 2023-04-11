using Microsoft.AspNetCore.Mvc;
using ShopOnline2022.Models;
using System.Diagnostics;

namespace ShopOnline2022.Controllers
{
    public class CardController : Controller
    {
        [Route("/thanh-toan", Name= "Checkout")]
        public IActionResult Checkout()
        {
            ViewBag.Title = "Thanh toán - ShopOnline";
            return View();
        }

        [Route("/gio-hang", Name = "ShoppingCart")]
        public IActionResult ShoppingCart()
        {
            ViewBag.Title = "Giỏ hàng - ShopOnline";
            return View();
        }
    }
}