using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Books;

namespace BookStore.Models.Utils
{
    public class CartItem
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
    }
}
