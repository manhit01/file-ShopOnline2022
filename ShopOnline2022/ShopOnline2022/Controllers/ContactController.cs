using Microsoft.AspNetCore.Mvc;
using ShopOnline2022.Models;
using System.Diagnostics;

namespace ShopOnline2022.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        [Route("/lien-he", Name = "Contact")]
        public IActionResult Index()
        {
            ViewBag.Title = "Liên Hệ - ShopOnline";
            return View();
        }

        [HttpPost]
        [Route("/lien-he", Name = "Contact")]
        public IActionResult Index(Contact item)
        {
            ViewBag.Title = "Liên Hệ - ShopOnline";
            return View();
        }
    }
}