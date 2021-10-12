using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookStore.Models.Books;
using BookStore.Models.Categories;

namespace BookStore.Models.CategorySubjects
{
    public class CategorySubject
    {
        public Guid Id { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
