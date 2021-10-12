using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Models.Orders;
using Microsoft.AspNetCore.Authorization;

namespace BookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Administrator")]
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Orders
        public async Task<IActionResult> Index()
        {
            var totalOrders = await _context.Order
                .OrderByDescending(o => o.OrderDate)
                .Include(o => o.User)
                .Include(o => o.OrderBook)
                .ThenInclude(ob => ob.Book)
                .ToListAsync();

            return View(totalOrders);
        }

        // GET: Admin/Orders/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .OrderByDescending(o => o.OrderDate)
                .Include(o => o.User)
                .Include(o => o.OrderBook)
                .ThenInclude(ob => ob.Book)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var order = await _context.Order.FindAsync(id);
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(Guid id)
        {
            return _context.Order.Any(e => e.Id == id);
        }

        public async Task<IActionResult> DeleteFromBookController(Guid orderId, Guid bookId)
        {
            var order = await _context.Order
                .Where(c => c.Id == orderId)
                .FirstOrDefaultAsync();

            if (order == null)
            {
                return NotFound();
            }

            _context.Order.Remove(order);

            await _context.SaveChangesAsync();

            return RedirectToAction("Orders", "Books", new { id = bookId });
        }
    }
}
