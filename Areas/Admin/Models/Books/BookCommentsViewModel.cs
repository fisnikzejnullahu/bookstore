using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Books;
using BookStore.Models.Comments;

namespace BookStore.Areas.Admin.Models
{
    public class BookCommentsViewModel
    {
        public Book Book { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
