using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Areas.Admin.Models.Dashboard
{
    public class TopUserItem
    {
        public string User { get; set; }
        public int Quantity { get; set; }
        public double TotalSpent { get; set; }
    }
}
