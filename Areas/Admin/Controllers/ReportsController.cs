using System;
using System.Collections.Generic;
using System.Linq;
using BookStore.Areas.Admin.Models.Dashboard;
using BookStore.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class ReportsController : Controller
    {
        private ApplicationDbContext _dbContext;

        public ReportsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult TopBooks()
        {
            var orderbooks = _dbContext.OrdersBooks
                    .Include(o => o.Book)
                    .GroupBy(o => o.BookId)
                    .Take(5)
                    .ToList();

            var topBooks = new List<TopSoldBookItem>();

            foreach (var orderbook in orderbooks)
            {
                int quantity = 0;
                var book = orderbook.ElementAt(0).Book;
                foreach (var item in orderbook)
                {
                    quantity += item.Quantity;
                }
                topBooks.Add(
                    new TopSoldBookItem
                    {
                        Book = book,
                        Quantity = quantity
                    }
                );

            }

            return View(topBooks);
        }

        public async Task<IActionResult> TopUsers()
        {
            var totalBooks = await _dbContext.Books.ToListAsync();

            var orders = _dbContext.Order
                    .Include(o => o.OrderBook)
                    .Include(o => o.User)
                    .GroupBy(o => o.UserId)
                    .Take(5)
                    .ToList();

            var topUsers = new List<TopUserItem>();

            foreach (var order in orders)
            {
                int quantity = 0;
                double totalSpent = 0;
                var user = order.ElementAt(0).User.Email;
                foreach (var orderbooks in order)
                {
                    foreach (var item in orderbooks.OrderBook)
                    {
                        quantity += item.Quantity;
                        totalSpent += (item.Quantity * item.Book.Price);
                    }
                }
                topUsers.Add(
                    new TopUserItem
                    {
                        User = user,
                        Quantity = quantity,
                        TotalSpent = totalSpent
                    }
                );

            }

            return View(topUsers);
        }
    }
}