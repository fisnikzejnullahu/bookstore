using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.Categories;
using BookStore.Models.CategorySubjects;

namespace BookStore.Models.Books
{
    public class BooksViewModel
    {
        public List<Category> Categories { get; set; }
        public List<CategorySubject> CategorySubjects { get; set; }
        public PaginatedList<Book> Books { get; set; }
    }
}
