using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookStore.Models.OrdersBooks;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Models.Orders
{
    public class Order
    {
        public Guid Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }

        //In a single order there are many books bought!
        public List<OrderBook> OrderBook { get; set; }

        public double TotalPriceOfOrder()
        {
            double sum = 0;
            this.OrderBook.ForEach(ob =>
            {
                sum += ob.Book.Price * ob.Quantity;
            });

            return sum;
        }

        public int TotalQuantityOfBooks()
        {
            int qty = 0;
            this.OrderBook.ForEach(ob => qty += ob.Quantity);

            return qty;
        }
    }
}
