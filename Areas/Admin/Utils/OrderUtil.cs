using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Models.Books;
using BookStore.Models.Orders;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Areas.Admin.Utils
{
    public static class OrderUtil
    {

        public static double GetTotalRevenueFromOrders(List<Order> orders)
        {
            double sum = 0;
            orders.ForEach(o =>
            {
                sum += o.TotalPriceOfOrder();
            });

            return sum;
        }
    }
}
