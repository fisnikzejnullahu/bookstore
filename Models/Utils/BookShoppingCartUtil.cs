using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Books;

namespace BookStore.Models.Utils
{
    public static class BookShoppingCartUtil
    {
        public static double TotalSumOfCart(List<CartItem> items)
        {
            double sum = 0;

            items.ForEach(b =>
            {
                sum += (b.Book.Price * b.Quantity);
            });

            return sum;
        }
    }
}
