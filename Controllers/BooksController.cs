using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Extensions;
using BookStore.Models;
using BookStore.Models.Books;
using BookStore.Models.Comments;
using BookStore.Models.Rates;
using BookStore.Models.Utils;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public string CurrentUserId => User.FindFirst(ClaimTypes.NameIdentifier).Value;


        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Books
        public async Task<IActionResult> Index(int? page, string author, double minPrice, double maxPrice, string publishedAt, string orderBy, Guid? subjectId)
        {

            var filterAuthor = "";
            var filterMinPrice = 0d;
            var filterMaxPrice = 99999999d;
            var filterPublishAt = 0;


            if (!string.IsNullOrWhiteSpace(author))
            {
                filterAuthor = author;
            }

            if (!string.IsNullOrWhiteSpace(publishedAt) && !publishedAt.Equals("All"))
            {
                try
                {
                    filterPublishAt = int.Parse(publishedAt);
                }
                catch (Exception)
                {
                    
                }
            }

            if (!Double.IsNaN(minPrice) && !Double.IsNegative(minPrice))
            {
                filterMinPrice = minPrice;
            }

            if (!Double.IsNaN(maxPrice) && maxPrice > 0 && !Double.IsNegative(maxPrice))
            {
                filterMaxPrice = maxPrice;
            }

            IQueryable<Book> books = null;

            List<string> years = new List<string>();
            years.Add("All");
            years.Add("2017");
            years.Add("2018");
            years.Add("2019");

            //if no publish date available, how to query?! so check for date!
            // get only years from books in db?
            if (filterPublishAt != 0)
            {
                books = _context.Books
                    .Where(b => b.Active)
                    .Where(b => b.Author.Contains(filterAuthor))
                    .Where(b => b.Price >= filterMinPrice)
                    .Where(b => b.Price <= filterMaxPrice)
                    .Where(b => b.PublishedDate.Year == filterPublishAt)
                    .AsNoTracking();

                ViewData["Years"] = new SelectList(years, publishedAt);
            }
            else
            {
                books = _context.Books
                    .Where(b => b.Active)
                    .Where(b => b.Author.Contains(filterAuthor))
                    .Where(b => b.Price >= filterMinPrice)
                    .Where(b => b.Price <= filterMaxPrice)
                    .AsNoTracking();

                ViewData["Years"] = new SelectList(years, "All");
            }

            if (subjectId != null)
            {
                books = books.Where(b => b.CategorySubjectId == subjectId);
            }

            if (orderBy != null)
            {
                switch (orderBy.ToLower())
                {
                    case "pricemintomax":
                        books = books.OrderBy(b => b.Price);
                        break;
                    case "pricemaxtomin":
                        books = books.OrderByDescending(b => b.Price);
                        break;
                }
            }

            int pageSize = 6;
            var vm = new BooksViewModel
            {
                Categories = await _context.Categories.ToListAsync(),
                CategorySubjects = await _context.CategorySubjects.ToListAsync(),
                Books = await PaginatedList<Book>.CreateAsync(books, page ?? 1, pageSize)
            };
            
            ViewData["minPrice"] = filterMinPrice;
            ViewData["maxPrice"] = filterMaxPrice;
            ViewData["author"] = filterAuthor;
            ViewData["publishedAt"] = filterPublishAt;
            ViewData["currentSubjectId"] = subjectId;
            ViewData["orderBy"] = orderBy;


            return View(vm);
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var book = await _context.Books
                .Include(b => b.Comments)
                .Include(b => b.Rates)
                .ThenInclude(r => r.User)
                .Include(b => b.CategorySubject.Category)
                .FirstOrDefaultAsync(b => b.Id == id && b.Active);

            if (book == null)
            {
                return NotFound();
            }

            var comments = await _context.Comments
                .Include(c => c.CommentHistory)
                .Include(c => c.CreatedByUser)
                .Where(c => c.Book == book)
                .ToListAsync();

            if (comments == null)
            {
                return NotFound();
            }

            var vm = new BookDetailsViewModel
            {
                Book = book,
                Comments = comments.OrderByDescending(c => c.CreatedDate).ToList()
            };
            
            return View(vm);
        }

        private bool BookExists(Guid id)
        {
            return _context.Books.Any(e => e.Id == id);
        }

        public async Task<IActionResult> DeleteComment(Guid? commentId, Guid? bookId)
        {
            if (commentId == null || bookId == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(c => c.CommentHistory)
                .Where(c => c.Id == commentId)
                .FirstOrDefaultAsync();

            if (comment == null)
            {
                return NotFound();
            }

            _context.Comments.Remove(comment);

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new {id = bookId});
        }

        [HttpPost]
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

            _context.Add(newComment);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new {id = BookId});
        }

        [HttpPost]
        public async Task<IActionResult> EditComment(string bookId, string commentId, string newCommentMsg)
        {
            var comment = await _context.Comments.Where(c => c.Id == Guid.Parse(commentId)).SingleAsync();

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

            _context.Update(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", new{id = bookId});
        }

        [HttpPost]
        public async Task<IActionResult> AddRate(string bookId, string userId, byte value)
        {
            if (value < 0 || value > 5 || bookId == null || userId == null)
            {
                return NotFound();
            }
            var rate = await _context.Rate.Where(r => r.UserId == userId && r.BookId == Guid.Parse(bookId) ).FirstOrDefaultAsync();

            if (rate == null)
            {
                rate = new Rate
                {
                    Id = new Guid(),
                    UserId = userId,
                    BookId = Guid.Parse(bookId),
                    Value = value,

                };

                _context.Add(rate);
                await _context.SaveChangesAsync();
            }
            else
            {
                rate.Value = value;
                _context.Update(rate);
                await _context.SaveChangesAsync();

            }

            return RedirectToAction("Details", new{id = bookId});
        }
    }
}
