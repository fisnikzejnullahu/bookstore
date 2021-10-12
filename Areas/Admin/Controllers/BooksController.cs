using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BookStore.Areas.Admin.Models;
using BookStore.Areas.Admin.Models.Books;
using BookStore.Data;
using BookStore.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using BookStore.Models.Books;
using BookStore.Models.Comments;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookStore.Areas.Admin.Utils;

namespace BookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        public BooksController(ApplicationDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _dbContext = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index(int? page)
        {
            var books = _dbContext.Books.Include(b => b.CategorySubject).AsNoTracking();

            int pageSize = 5;
            var vm = new IndexViewModel
            {
                Books = await PaginatedList<Book>.CreateAsync(books, page ?? 1, pageSize)
            };

            return View(vm);
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _dbContext.Books
                .Where(b => b.Id == id)
                .Include(b => b.CategorySubject)
                .FirstOrDefaultAsync();

            if (book == null)
            {
                return NotFound();
            }
            ViewData["CategorySubjectId"] = new SelectList(_dbContext.CategorySubjects, "Id", "Name");

            return View(book);
        }

        public IActionResult Create()
        {
            ViewData["CategorySubjectId"] = new SelectList(_dbContext.CategorySubjects, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book, IFormFile thumbnailFile)
        {
            ViewData["CategorySubjectId"] = new SelectList(_dbContext.CategorySubjects, "Id", "Name", book.CategorySubjectId);

            if (!string.IsNullOrEmpty(book.Isbn))
            {
                var testIsbnUnique = await _dbContext.Books.Where(b => b.Isbn == book.Isbn).FirstOrDefaultAsync();

                if (testIsbnUnique != null)
                {
                    ModelState.AddModelError("Isbn", "Book with that Isbn already exists. Please try another one.");
                }
            }

            if (ModelState.IsValid)
            {
                book.Id = Guid.NewGuid();

                if (thumbnailFile != null)
                {
                    var fileNameAsync = ImagesUtil.CreateImageFile(thumbnailFile);
                    book.Thumbnail = fileNameAsync.Result;
                }

                _dbContext.Add(book);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _dbContext.Books
                .Where(b => b.Id == id)
                .Include(b => b.CategorySubject)
                .FirstOrDefaultAsync();

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Book book, string isEditingBook, IFormFile thumbnailFile)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(book.Isbn))
            {
                var testIsbnUnique = await _dbContext.Books.Where(b => b.Isbn == book.Isbn).Include(b => b.CategorySubject).AsNoTracking().FirstOrDefaultAsync();

                if (testIsbnUnique != null && !testIsbnUnique.Id.Equals(book.Id))
                {
                    book.CategorySubject = testIsbnUnique.CategorySubject;
                    ModelState.AddModelError("Isbn", "Book with that Isbn already exists. Please try another one.");
                }
            }

            if (ModelState.IsValid)
            {
                try
                {

                    if (thumbnailFile != null)
                    {
                        var fileNameAsync = ImagesUtil.CreateImageFile(thumbnailFile);
                        book.Thumbnail = fileNameAsync.Result;
                    }
                    else
                    {
                        book.Thumbnail = book.Thumbnail;
                    }

                    _dbContext.Update(book);
                    await _dbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                if (isEditingBook != null)
                {
                    return RedirectToAction(nameof(Details), new { id = id });
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(nameof(Details), book);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _dbContext.Books
                .Include(b => b.CategorySubject)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var book = await _dbContext.Books.FindAsync(id);
            _dbContext.Books.Remove(book);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(Guid id)
        {
            return _dbContext.Books.Any(e => e.Id == id);
        }

        public async Task<IActionResult> AddComment(string BookId, string comment)
        {
            var newComment = new Comment
            {
                Id = Guid.NewGuid(),
                CreatedByUserId = CurrentUserId,
                BookId = Guid.Parse(BookId),
                CreatedDate = DateTime.Now
            };

            var commentHistory = new CommentHistory
            {
                Id = Guid.NewGuid(),
                EditedTime = DateTime.Now,
                Message = comment
            };

            newComment.CommentHistory = new List<CommentHistory>();
            newComment.CommentHistory.Add(commentHistory);

            _dbContext.Add(newComment);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditComment(string commentId, string newCommentMsg)
        {
            if (commentId == null || newCommentMsg == null)
            {
                return NotFound();
            }

            var comment = await _dbContext.Comments.Where(c => c.Id == Guid.Parse(commentId)).SingleOrDefaultAsync();

            if (comment == null)
            {
                return NotFound();
            }

            if (comment.CommentHistory == null)
            {
                comment.CommentHistory = new List<CommentHistory>();
            }
            comment.CommentHistory.Add(
                new CommentHistory
                {
                    Id = Guid.NewGuid(),
                    EditedTime = DateTime.Now,
                    Message = newCommentMsg
                });

            _dbContext.Update(comment);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private Task<Comment> FindComment(string commentId)
        {
            return null;
        }

        public string CurrentUserId => User.FindFirst(ClaimTypes.NameIdentifier).Value;

        public async Task<IActionResult> Comments(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = await _dbContext.Books
                .Where(b => b.Id == id)
                .SingleOrDefaultAsync();

            if (book == null)
            {
                return NotFound();
            }

            var comments = await _dbContext.Comments
                .Include(c => c.CommentHistory)
                .Include(c => c.CreatedByUser)
                .Where(c => c.Book == book)
                .ToListAsync();

            if (comments == null)
            {
                return NotFound();
            }

            var vm = new BookCommentsViewModel
            {
                Book = book,
                Comments = comments
            };

            return View(vm);
        }

        public async Task<IActionResult> CommentDetails(Guid? commentId)
        {
            if (commentId == null)
            {
                return NotFound();
            }

            Comment comment = await _dbContext.Comments
                .Include(c => c.CommentHistory)
                .Include(c => c.CreatedByUser)
                .Include(c => c.Book)
                .Where(c => c.Id == commentId)
                .SingleOrDefaultAsync();

            if (comment == null)
            {
                return NotFound();
            }

            var allUsers = await _dbContext.Users.ToListAsync();

            var cdvm = new CommentDetailsViewModel
            {
                Comment = comment,
            };

            return View(cdvm);
        }

        public async Task<IActionResult> Rates(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _dbContext.Books
                .Where(b => b.Id == id)
                .Include(b => b.Rates)
                .ThenInclude(r => r.User)
                .SingleOrDefaultAsync();

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        public async Task<IActionResult> Orders(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _dbContext.Books
                .Where(b => b.Id == id)
                .FirstOrDefaultAsync();

            if (book == null)
            {
                return NotFound();
            }

            var orderbooks = await _dbContext.OrdersBooks
                .Include(o => o.Book)
                .Include(o => o.Order)
                .ThenInclude(ob => ob.User)
                .Where(o => o.BookId == id)
                .ToListAsync();

            if (orderbooks == null)
            {
                return NotFound();
            }

            var vm = new BookOrdersViewModel
            {
                Book = book,
                OrderBooks = orderbooks
            };

            return View(vm);
        }

    }
}
