using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;

namespace BookStore.Controllers
{
    public class OrderHistoryController : Controller
    {
        private ApplicationDbContext _dbContext;

        public string CurrentUserId => User.FindFirst(ClaimTypes.NameIdentifier).Value;
        
        public OrderHistoryController(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public IActionResult Index()
        {

            var orders = _dbContext.Order
                .OrderByDescending(o => o.OrderDate)
                .Include(o => o.OrderBook)
                .ThenInclude(ob => ob.Book)
                .Where(o => o.UserId == CurrentUserId)
                .ToList();

            return View(orders);
        }
    }
}