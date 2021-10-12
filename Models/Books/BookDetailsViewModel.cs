using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Comments;

namespace BookStore.Models.Books
{
    public class BookDetailsViewModel
    {
        public Book Book { get; set; }
        public List<Comment> Comments { get; set; }
        
    }
}
