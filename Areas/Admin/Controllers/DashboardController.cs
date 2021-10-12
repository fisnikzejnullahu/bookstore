using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Areas.Admin.Models.Dashboard;
using BookStore.Areas.Admin.Utils;
using BookStore.Data;
using BookStore.Models.Orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class DashboardController : Controller
    {

        private readonly ApplicationDbContext _dbContext;
        private UserManager<IdentityUser> _userManager;

        public DashboardController(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var totalBooks = await _dbContext.Books.CountAsync();
            var totalUsers = await _userManager.Users.CountAsync();
            var totalOrders = await _dbContext.Order
                                            .OrderByDescending(o => o.OrderDate)
                                            .Include(o => o.User)
                                            .Include(o => o.OrderBook)
                                            .ThenInclude(ob => ob.Book)
                                            .ToListAsync();

            var vm = new DashboardViewModel
            {
                TotalBooks = totalBooks,
                TotalUsers = totalUsers,
                TotalOrders = totalOrders.Count,
                Orders = totalOrders
            };

            return View(vm);
        }
    }

}