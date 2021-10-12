using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Extensions;
using BookStore.Models.Books;
using BookStore.Models.Orders;
using BookStore.Models.OrdersBooks;
using BookStore.Models.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    [Authorize]
    public class CartController : Controller
    {

        private readonly ApplicationDbContext _dbContext;

        public string CurrentUserId => User.FindFirst(ClaimTypes.NameIdentifier).Value;


        public CartController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            var cartBooks = HttpContext.Session.GetObjectFromJson<List<CartItem>>("BookShoppingCart");
            return View(cartBooks);
        }

        public IActionResult Checkout()
        {
            var cartBooks = HttpContext.Session.GetObjectFromJson<List<CartItem>>("BookShoppingCart");
            var totalPaymentPrice = BookShoppingCartUtil.TotalSumOfCart(cartBooks);
            ViewData["totalPaymentPrice"] = totalPaymentPrice;
            
//            ViewData["UserId"] = new SelectList(CultureInfo.CurrentCulture.DateTimeFormat.MonthNames, "Id", "UserName");
            return View();
        }

        public IActionResult CheckoutSuccess()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Pay()
        {
            var bookShoppingCart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("BookShoppingCart");

            var order = new Order
            {
                Id = Guid.NewGuid(),
                OrderDate = DateTime.Now,
                UserId = CurrentUserId
            };

            var orderbook = new List<OrderBook>();

            bookShoppingCart.ForEach(b =>
            {
                //TODO: resetsessioncart kur te payirat
                //TODO: edhe kur bon logout bone resetsession
                Console.WriteLine("ADDED " + b.Quantity + ", " + b.Book.Id);
                orderbook.Add(new OrderBook
                {
                    BookId = b.Book.Id,
                    OrderId = order.Id,
                    Quantity = b.Quantity
                });
            });

            order.OrderBook = orderbook;

            await _dbContext.Order.AddAsync(order);
            await _dbContext.SaveChangesAsync();
            ResetCart();
            
            return RedirectToAction(nameof(CheckoutSuccess));
        }

        public async Task<IActionResult> AddToCart(Guid? bookId, int? quantity)
        {
            if (bookId == null)
            {
                return NotFound();
            }

            if (quantity == null || quantity < 1 || quantity > 100)
            {
                return NotFound();
            }

            var book = await _dbContext.Books
                .Where(b => b.Id == bookId)
                .FirstOrDefaultAsync();

            if (book == null)
            {
                return NotFound();
            }

            var bookShoppingCart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("BookShoppingCart");
            var inCartBook = bookShoppingCart.FirstOrDefault(b => b.Book.Id == bookId);

            if (inCartBook == null)
            {
                bookShoppingCart.Add(new CartItem
                {
                    Book = book,
                    Quantity = quantity.Value
                });
            }
            else
            {
                inCartBook.Quantity += quantity.Value;
            }

            HttpContext.Session.SetObjectAsJson("BookShoppingCart", bookShoppingCart);

            return RedirectToAction("Details", "Books", new { id = bookId });
        }

        public IActionResult RemoveFromCart(Guid bookId)
        {
            var bookShoppingCart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("BookShoppingCart");
            var bookInShoppingCart = bookShoppingCart.FirstOrDefault(b => b.Book.Id == bookId);

            if (bookInShoppingCart != null)
            {
                bookShoppingCart.Remove(bookInShoppingCart);
                HttpContext.Session.SetObjectAsJson("BookShoppingCart", bookShoppingCart);
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Reset()
        {
            ResetCart();

            return RedirectToAction(nameof(Index));
        }

        private void ResetCart()
        {
            HttpContext.Session.Clear();

            var bookShoppingCart = new List<CartItem>();
            HttpContext.Session.SetObjectAsJson("BookShoppingCart", bookShoppingCart);
        }
    }
}