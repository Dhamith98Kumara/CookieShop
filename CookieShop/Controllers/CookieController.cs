using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CookieShop.Controllers
{
    public class CookieController : Controller
    {
        public static List<CookieViewModel> cookie = new List<CookieViewModel>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Order()
        {
            var obj = new CookieViewModel();
            return View(obj);
        }

        public IActionResult OrderCookie(CookieViewModel cvm)
        {
            cookie.Clear();
            cookie.Add(cvm);
            return RedirectToAction(nameof(ThankYou));
        }

        public IActionResult ThankYou()
        {
            return View(cookie);
        }
    }
}
