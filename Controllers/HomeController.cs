using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Extensions;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using BookStore.Models.Books;
using BookStore.Models.Utils;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories
                .Include(c => c.Subjects)
                .ToListAsync();

            if (!HttpContext.Session.Keys.Contains("BookShoppingCart"))
            {
                var bookShoppingCart = new List<CartItem>();
                HttpContext.Session.SetObjectAsJson("BookShoppingCart", bookShoppingCart);
            }

            return View(categories);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Message from About Action";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
