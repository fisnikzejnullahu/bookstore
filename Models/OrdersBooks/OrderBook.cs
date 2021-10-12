using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Books;
using BookStore.Models.Orders;

namespace BookStore.Models.OrdersBooks
{
    public class OrderBook
    {
        public Guid BookId { get; set; }
        public Book Book { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public int Quantity { get; set; }
    }
}
