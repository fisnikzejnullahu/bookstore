using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Books;

namespace BookStore.Areas.Admin.Utils
{
    public static class RatesUtil
    {
        public static double AverageRate(Book book)
        {
            double sum = 0;
            double totalRates = book.Rates.Count;

            book.Rates.ForEach(r => { sum += r.Value; });

            var avg = Math.Round(sum / totalRates, 2);
            return Double.IsNaN(avg) ? 0 : avg;
        }
    }
}
