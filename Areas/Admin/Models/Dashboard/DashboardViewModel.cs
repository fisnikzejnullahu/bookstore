using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Areas.Admin.Utils;
using BookStore.Models.Orders;

namespace BookStore.Areas.Admin.Models.Dashboard
{
    public class DashboardViewModel
    {
        public int TotalBooks { get; set; }
        public int TotalUsers { get; set; }
        public int TotalOrders { get; set; }
        public double ThisMonthRevenueFromOrders { get; set; }
        public List<Order> Orders { get; set; }

        public double CalculateRevenueMonth()
        {
            var today = DateTime.Today;
            var thisMonth = new DateTime(today.Year, today.Month, 1);
            var thisMonthOrders = Orders.Where(o => o.OrderDate.Month == today.Month).ToList();
            var lastMonthOrders = Orders.Where(o => o.OrderDate.Month == thisMonth.AddMonths(-1).Month).ToList();

            double lastMonthRevenue = OrderUtil.GetTotalRevenueFromOrders(lastMonthOrders);
            double thisMonthRevenue = OrderUtil.GetTotalRevenueFromOrders(thisMonthOrders);
            ThisMonthRevenueFromOrders = thisMonthRevenue;

            return thisMonthRevenue - lastMonthRevenue;
        }
    }
}
