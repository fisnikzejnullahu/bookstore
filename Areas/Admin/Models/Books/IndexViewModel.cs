using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Models.Books;

namespace BookStore.Areas.Admin.Models.Books
{
    public class IndexViewModel
    {
        public PaginatedList<Book> Books { get; set; }
    }


}
