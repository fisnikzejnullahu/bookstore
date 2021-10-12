using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Books;

namespace BookStore.Areas.Admin.Models.Dashboard
{
    public class TopSoldBookItem
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
