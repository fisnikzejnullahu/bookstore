using System;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class RatesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public RatesController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<IActionResult> Delete(Guid rateId, Guid bookId)
        {
            var rate = await _dbContext.Rate
                .Where(c => c.Id == rateId)
                .FirstOrDefaultAsync();

            if (rate == null)
            {
                return NotFound();
            }

            _dbContext.Rate.Remove(rate);

            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Rates", "Books", new {id = bookId});
        }
    }
}