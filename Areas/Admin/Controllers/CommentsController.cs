using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class CommentsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CommentsController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<IActionResult> Delete(Guid commentId, Guid bookId)
        {
            var comment = await _dbContext.Comments
                .Include(c => c.CommentHistory)
                .Where(c => c.Id == commentId)
                .FirstOrDefaultAsync();

            if (comment == null)
            {
                return NotFound();
            }

            _dbContext.Comments.Remove(comment);

            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Comments", "Books", new {id = bookId});
        }
    }
}