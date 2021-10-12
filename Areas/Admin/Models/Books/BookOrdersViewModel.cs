using System.Collections.Generic;
using BookStore.Models.Books;
using BookStore.Models.Comments;
using BookStore.Models.OrdersBooks;

namespace BookStore.Areas.Admin.Models
{
    public class BookOrdersViewModel
    {
        public Book Book { get; set; }
        public List<OrderBook> OrderBooks { get; set; }
    }
}
